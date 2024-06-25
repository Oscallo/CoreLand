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

using System.Windows;

namespace CoreLand.Design.Windows
{
    public interface IWindow
    {
        public double Height { get; set; }
        
        public double MinHeight { get; set; }

        public double MaxHeight { get; set; }

        public double Width { get; set; }

        public double MinWidth { get; set; }

        public double MaxWidth { get; set; }

        public string Title { get; set; }

        public object Content { get; set; }

        public Visibility Visibility { get; set; }

        public void Show();

        public void Hide();
    }
}
