using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PUBG_APP
{
   public class NameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private NameModel RatingModel;
        private NameModel SeasonIdModel;
        
        public NameViewModel()
        {
            RatingModel = new NameModel();
            SeasonIdModel = new NameModel();
        }

        public string PlayerRating
        {
            get { return RatingModel.PlayerRating; }
            set
            {
                if(RatingModel.PlayerRating != value)
                {
                    RatingModel.PlayerRating = value;
                    //OnPropertyChanged("PlayerName");

                }
            }
        }
        public string SeasonId {
            get { return SeasonIdModel.SeasonId; }
            set
            {
                if(SeasonIdModel.SeasonId != value)
                {
                    SeasonIdModel.SeasonId = value;
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
