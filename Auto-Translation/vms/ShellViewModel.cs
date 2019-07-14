using System.Collections.Generic;
using System.Windows;

namespace Auto_Translation.vms
{
    //  [Export(typeof(IShell))]
    class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        public Dictionary<string,ResourceDictionary> Themes { get; set; }
    }
}
