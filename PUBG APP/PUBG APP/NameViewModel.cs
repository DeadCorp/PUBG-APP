using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PUBG_APP
{
   public class NameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private NameModel nameModel;
         
        public NameViewModel()
        {
            nameModel = new NameModel();
        }

        public string PlayerName
        {
            get { return nameModel.PlayerName; }
            set
            {
                if(nameModel.PlayerName!=value)
                {
                    nameModel.PlayerName = value;
                    //OnPropertyChanged("PlayerName");

                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
