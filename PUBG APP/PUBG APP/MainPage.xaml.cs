using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PUBG_APP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string Player_Id_Case;
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Player_Id_Completed(object sender, EventArgs e)
        {
            Player_Id_Case = Player_Id.Text;
            
        }
    }
}