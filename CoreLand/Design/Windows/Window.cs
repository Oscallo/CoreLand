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

using System.Windows.Controls;

namespace CoreLand.Design.Windows
{
    public class Window : ContentControl, IWindow
    {
        string IWindow.Title { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }


        static Window() 
        {
        
        }

        public Window() 
        {
        
        }

        void IWindow.Show() => throw new System.NotImplementedException();
        void IWindow.Hide() => throw new System.NotImplementedException();
    }
}
