using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Auto_Translation
{
    //  [Export(typeof(IShell))]
    class ShellViewModel : PropertyChangedBase, IShell
    {
        public void ChangeLang(Button btn)
        {
            var langs = ((string)btn.Tag).Split(',');
            if(btn.CommandParameter ==null)
            btn.CommandParameter = 0;

            var index = (int)btn.CommandParameter;
            if (index >= langs.Length) index = 0;

            Application.Current.Resources.MergedDictionaries[0] = new ResourceDictionary
            {
                Source = new Uri(string.Format(@".\Themes\{0}\Strings.xaml", langs[index]), uriKind: UriKind.Relative)
            };

            btn.CommandParameter = ++index;
        }

        public void SelectFiles()
        {
            
        }


    }
}
