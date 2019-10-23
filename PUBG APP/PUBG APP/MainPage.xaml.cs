using PubgNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace PUBG_APP
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {

        string q;
        public   MainPage()
        {
            InitializeComponent();



            Detail = new NavigationPage(new Search())
            {
                BarBackgroundColor = Color.FromHex("#1262c9")
            };

            IsPresented = false;
        }
        public MainPage(string s)
        {
            this.BindingContext = new NameViewModel
            {
                PlayerName = s
                
            };
            q = s;
        }
        
        

        private  void Button_Clicked_season(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SeasonStat(q))
            {
                BarBackgroundColor = Color.FromHex("#1262c9")
            };

            IsPresented = false;


        }

        private  void Button_Clicked_lifetime(object sender, EventArgs e)
        {
            IsPresented = false;
        }

        private void Button_Clicked_search(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Search())
            {
                BarBackgroundColor = Color.FromHex("#1262c9")
            };
            IsPresented = false;
        }
        public static string GetApi()
        {
            return "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        }
    }
}