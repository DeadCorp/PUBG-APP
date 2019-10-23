
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PUBG_APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeasonStat : TabbedPage
    {
        
        public SeasonStat(string s)
        {
            
            InitializeComponent();
            this.BindingContext = new NameViewModel
            {
                PlayerName = s
            };

        }
    }
}