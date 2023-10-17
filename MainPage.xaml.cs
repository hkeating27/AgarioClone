using AgarioModels;
using Communications;
using Microsoft.Extensions.Logging;

namespace ClientGUI
{
    public partial class MainPage : ContentPage
    {
        //Fields
        private Networking network;
        private AgarioWorld worldState;
        private ILogger logger;
        private string playerName;
        private string serverName;
        private Player playerObject;

        public MainPage(ILogger<MainPage> logger)
        {
            InitializeComponent();
            this.logger = logger;
            worldState = new AgarioWorld(logger);
            network = new Networking(logger, onConnect, onDisconnect, onMessageRecieved, '\n');
            playerName = "";
            serverName = "";
            drawableWorld draw = new drawableWorld(agarioWorld, worldState.getPlayers(), worldState.getFood());
            agarioWorld.Drawable = draw;
        }

        private void Connect(object sender, EventArgs e)
        {
            try
            {
                if (playerName == "" || serverName == "")
                {
                    Label error = new Label();
                    error.Text = "You must input both a player name and a server name";
                    errors.Add(error);
                }
                else
                    network.Connect(serverName, 11000);
            }
            catch (Exception ex)
            {
                Label connectionError = new Label();
                connectionError.Text = ex.Message;
                errors.Add(connectionError);
            }
        }

        private void onConnect(Networking client)
        {
            agarioScreen.IsVisible  = true;
            startUpScreen.IsVisible = false;
            playerObject = new Player(playerName);
            worldState.addItemToList(playerObject);
            redrawWorld();
            
        }

        private void onDisconnect(Networking client)
        {

        }

        private void onMessageRecieved(Networking client, string message)
        {

        }

        private void NewPlayerName(object sender, EventArgs e)
        {
            playerName = (sender as Entry).Text;
        }

        private void NewServerName(object sender, EventArgs e)
        {
            serverName = (sender as Entry).Text;
        }

        private void PointerChanged(object sender, EventArgs e)
        {

        }

        private void OnTap(object sender, EventArgs e)
        {

        }

        private void PanUpdated(object sender, EventArgs e)
        {

        }

        private void redrawWorld()
        {
            agarioWorld.Invalidate();
        }
    }
}