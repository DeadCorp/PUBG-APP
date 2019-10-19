using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PubgNet;



namespace PUBG_APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        static string Player_Id_Case;
        static string id_acc;
        
        
        
        public Search()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            MainAsync();
        }
        async Task MainAsync()
        { 
            PubgNetClient client = new PubgNetClient(MainPage.getApi());
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
        private void Player_Id_Completed(object sender, EventArgs e)
        {
            Player_Id_Case = Player_Id.Text;
        }
        
}
}