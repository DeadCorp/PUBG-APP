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
        static string[] reg =  
        {
        "psn",              // — PS4
        "steam",            // — Steam
        "tournament",       // — Tournaments
        "xbox"              // — Xbox
        };
        static string[] plat =
        {
            "pc-as",        // — Asia
            "pc-eu",        // — Europe
            "pc-jp",        // — Japan
            "pc-kakao",     // — Kakao
            "pc-krjp",      // — Korea
            "pc-na",        // — North America
            "pc-oc",        // — Oceania
            "pc-ru",        // — Russia
            "pc-sa",        // — South and Central America
            "pc-sea",       // — South East Asia
            "pc-tournament",// — Tournaments
            "psn-as",       // — Asia
            "psn-eu",       // — Europe
            "psn-na",       // — North America
            "psn-oc",       // — Oceania
            "xbox-as",      // — Asia
            "xbox-eu",      // — Europe
            "xbox-na",      // — North America
            "xbox-oc",      // — Oceania
            "xbox-sa",      // — South America
        };
       
        public   MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Search());
            IsPresented = false;
            
        }
        
        

        private async void Button_Clicked_season(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new SeasonStat());
            IsPresented = false;
              
        }

        private async void Button_Clicked_lifetime(object sender, EventArgs e)
        {
            IsPresented = false;
        }

        private void Button_Clicked_search(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Search());
            IsPresented = false;
        }
        public static string getApi()
        {
            return "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        }
    }
}