using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace SeniorProject_Client.ViewModels
{
    [Export(typeof(TestViewModel))]
    class TestViewModel : PropertyChangedBase
    {
        private int _count = 50;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
            }
        }

        public string ImportantText
        {
            get { return "Other Important Text! So Read It!"; }
        }
    }
}
