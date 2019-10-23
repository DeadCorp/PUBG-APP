using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PubgNet;
using PUBG_APP;


namespace PUBG_APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Solo_FPP : ContentPage
    {


        static string Player_Id_Case;
        static string id_acc;
        

        public Solo_FPP()
        {
            InitializeComponent();
        }

        

        private void SwitchToTPP(object sender, ToggledEventArgs e)
        {
            
        }
    }
}