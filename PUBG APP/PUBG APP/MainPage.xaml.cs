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
        static string Name;
        PubgNetClient client = new PubgNetClient(GetApi());
        SeasonStat season = new SeasonStat()
        {
            BarBackgroundColor = Color.FromHex("#1262c9")
        };
        public Page Page => season;

        public static string GetName() { return Name; }
        public   MainPage()
        {
            InitializeComponent();
            this.Detail = new NavigationPage(Page);         

            IsPresented = true;
        }

        


        private  void Button_Clicked_season(object sender, EventArgs e)
        {
            
            
            this.Detail = new NavigationPage(Page);

            IsPresented = false;

            
        }

        private  void Button_Clicked_lifetime(object sender, EventArgs e)
        {
            IsPresented = false;
        }

        
       
        public static string GetApi()
        {
            return "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI";
        }

        

        private void Button_Clicked_Name(object sender, EventArgs e)
        {
            Name = PlayerNameEntry.Text;
            IsPresented = false;
            TakeGameData();


        }
        private async Task TakeGameData()
        {
            string IdTemp = null;
            string SeasonIdTemp = null;
           
            if (Name == null)
                await DisplayAlert("Уведомление", "Введите ник игрока", "ОK");
            else
            {
                
                var players = await client.GetPlayersByUsernames(new string[] { Name });
                if (players == null)
                    await DisplayAlert("Уведомление", "Неверный  ник игрока", "ОK");
                var seasons = await client.GetSeasons();
                foreach (var item in seasons.Data)
                {
                    SeasonIdTemp += item.Id + ",";
                }
                foreach (var item in players.Data)
                {
                    
                    IdTemp = item.Id;
                }
                this.BindingContext = new NameViewModel
                {
                    PlayerRating = IdTemp,
                    SeasonId = SeasonIdTemp
                    
                };
            }
        }
    }
}