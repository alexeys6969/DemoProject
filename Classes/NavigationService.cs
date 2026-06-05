using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Classes
{
    public static class NavigationService
    {
        private static ContentControl? _frame;

        public static void Initialize(ContentControl frame)
        {
            _frame = frame;
        }

        public static void NavigateTo(UserControl page)
        {
            if (_frame != null)
            {
                _frame.Content = page;
            }
        }
    }
}
