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
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string Player_Id_Case;
        string id_acc;
        int i = 0;
        public   MainPage()
        {
            InitializeComponent();

        }

        private void Player_Id_Completed(object sender, EventArgs e)
        {
            Player_Id_Case = Player_Id.Text;
            
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            MainAsync();
           
            
            
        }
        async Task MainAsync()
        {
            PubgNetClient client = new PubgNetClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI");
            var players = await client.GetPlayersByUsernames(new string[] { Player_Id_Case });
            foreach (var s in players.Data)
            {
                id_acc = s.Id;

                setc(id_acc);
            }
        }
        private void setc(string q) => Label_Player_Id.Text = q;

        private void Player_Id_Completed(object sender, FocusEventArgs e)
        {
            Player_Id_Case = Player_Id.Text;
        }
        /*  MainAsync().Wait();
 async Task MainAsync()
 {
     string maxkill = null;
     /*string id_name = null;
     string id_match = null;
     PubgNetClient client = new PubgNetClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI");
     var players = await client.GetPlayersByUsernames(new string[]{"DeadCorporation"});


     var season2 = await client.GetSeasons();
      foreach(var s in players.Data)
       {
           id_name = s.Id;
       }
     foreach (var i in season2.Data)
     {

         if (i.Attributes.IsCurrentSeason)
         {
              id_match = i.Id;
         }
         var season = await client.GetSeasonStatsForPlayer(id_name,id_match);
     }

     *//*
     string id_name = null;
     PubgNetClient client = new PubgNetClient("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI0ZjYyODUxMC1kM2UwLTAxMzctZDdhNC0wZjNhMTg5NGE0ZTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTcxNDA4NDA3LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6ImNpcGlkcmlzLWdtYWlsIn0.vTbdRV5CgGMOUUU7zDmMojlSULLafjhfFbBfEkbidjI");
     var players = await client.GetPlayersByUsernames(new string[] { "DeadCorporation" });
     foreach (var s in players.Data)
     {
         id_name = s.Id;
         maxkill = id_name;
         break;
     }
     Console.WriteLine(maxkill);
     System.Console.ReadKey();

 }
*/


    }
}