using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PubgNet;
using PUBG_APP;



namespace PUBG_APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search
    {


        static string Player_Id_Case;
        static string id_acc;

        //BackgroundImage="{local:ImageResource PUBG_APP.Images.logoPubg.jpg}
        //<StackLayout Padding = "10" HorizontalOptions="FillAndExpand" >
        //    <Image Aspect = "AspectFill" Source="{local:ImageResource PUBG_APP.Images.logoPubg.jpg}"/>
        //    <Entry x:Name="Player_Id" Placeholder="Введите имя игрока (Чуствительно к регистру)"  Completed="Player_Id_Completed"
        //                 FontSize="Caption" Unfocused="Player_Id_Completed" HorizontalOptions="Fill" Margin="5,5,5,0"/>
        //    <Button x:Name="Button1" Text="Поиск" Clicked="Button1_Clicked" Margin="2" HorizontalOptions="CenterAndExpand"/>
        //    <Label x:Name="Label_Player_Id"/>
        //</StackLayout>

        public Search()
        {
            InitializeComponent();

        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            // MainAsync();
            //MainPage a = 
            //NavigationPage nav =  new NavigationPage(new MainPage()
            //{
            //    Detail = new NavigationPage(new SeasonStat(Player_Id_Case))
            //    {
            //        BarBackgroundColor = Color.FromHex("#1262c9")
            //    },
            //    IsPresented = false
            //}
            //);
            
            Navigation.PushModalAsync(new MainPage()
            {

                Detail = new NavigationPage(new SeasonStat(Player_Id_Case))
                {
                    BarBackgroundColor = Color.FromHex("#1262c9")
                },
                IsPresented = false
                

            }
            ,false);
            
        }
    
           
        
        async Task MainAsync()
        {
            PubgNetClient client = new PubgNetClient(MainPage.GetApi());
            //r player = await client.GetPlayersByUsernames(new string[] { Player_Id_Case });
            //r season = await client.GetSeasons();
            //foreach (var i in player.Data)
            //{
            //    id_acc = i.Id;
            //   // setc(id_acc);
            //}

        }
        //private void setc(string q) => Rating.Text = q;
        private void Player_Id_Completed(object sender, FocusEventArgs e)
        {
            //PlayerName = Player_Id.Text;
            Player_Id_Case = Player_Id.Text;
        }
        private void Player_Id_Completed(object sender, EventArgs e)
        {
           // PlayerName = Player_Id.Text;
            Player_Id_Case = Player_Id.Text;
        }
        
}
}