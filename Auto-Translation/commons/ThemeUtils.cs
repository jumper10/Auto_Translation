using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Auto_Translation.commons
{
    static class ThemeUtils
    {
        public static void BindResource(this FrameworkElement fe,DependencyProperty dp,string key)
        {
            Style style = fe.Style as Style;
            var r = Application.Current.Resources[key];
            foreach (Setter s in style.Setters)
            {
                if (s.Property ==dp)
                {
                    s.Value = r;
                }
            }
        }
    }
}
