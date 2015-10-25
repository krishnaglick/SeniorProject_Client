using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace SeniorProject_Client.ViewModels
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : PropertyChangedBase
    {
        public string ImportantText
        {
            get { return "Super Important Text! So Read It!"; }
        }
    }
}
