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

using System;
using System.Windows;

namespace CoreLand.Design.Windows.Args
{
    public class TitleChangedEventArgs : EventArgs
    {
        public string OldTitle { get; set; } = string.Empty;

        public string NewTitle { get; set; } = string.Empty;

        public TitleChangedEventArgs(string oldValue, string newValue) 
        {
            this.OldTitle = oldValue;
            this.NewTitle = newValue;   
        }

        public static TitleChangedEventArgs From(DependencyPropertyChangedEventArgs eventArgsDP)
        {
            if (eventArgsDP.Property.Name != nameof(IWindow.Title)) { throw new InvalidCastException("Не возможно использвать DependencyPropertyChangedEventArgs для создания типа. Свойство DP не соответствует."); }

            return new TitleChangedEventArgs((string)eventArgsDP.OldValue, (string)eventArgsDP.NewValue);
        }
    }
}
