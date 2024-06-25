/*
 * Copyright 2024 Oscallo
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using CoreLand.Design.Windows.Args;
using System;
using System.Windows;
using System.Windows.Controls;

namespace CoreLand.Design.Windows
{
    public class Window : ContentControl, IWindow
    {
        static Window() 
        {
        
        }

        public Window() 
        {
        
        }

        public event NotifyTitleChangedEventHandler? TitleChanged;

        public string Title 
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(IWindow.Title), typeof(string), typeof(Window),
                                                                  new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(OnTitleChangedCallback)), new ValidateValueCallback(ValidateText));

        private static void OnTitleChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgsDP) 
        {
            Window window = (Window)dependencyObject;

            window.OnTitleChanged(TitleChangedEventArgs.From(eventArgsDP));
        }

        private static bool ValidateText(object value) 
        {
            if (value == null) { return false; }
            if (value is not string) { return false; }
            return true;
        }

        protected virtual void OnTitleChanged(TitleChangedEventArgs e)
        {
            if (this.TitleChanged != null)
            {
                this.TitleChanged?.Invoke(this, e);
            }
        }

        void IWindow.Show() => throw new NotImplementedException();

        void IWindow.Hide() => throw new NotImplementedException();
    }
}
