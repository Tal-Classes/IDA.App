using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace IDA.App.ViewModels
{
  public  class LogInViewModels:ViewModelBase
    {
        private int entryEmail;
        public int EntryEmail { get { return entryEmail; } set { entryEmail = value; OnPropertyChanged("EntryEmail"); } }

        private int entryPass;
        public int EntryPass { get { return entryPass; } set { entryPass = value; OnPropertyChanged("EntryPass"); } }


        public ICommand LogInCommand { protected set; get; }
        public ICommand RegisterCommand { protected set; get; }
      

    }
}
