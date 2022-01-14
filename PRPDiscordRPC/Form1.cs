using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Newtonsoft.Json;
using DiscordRPC;
using SampAPI;

namespace PRPDiscordRPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(3000);
            DiscordRpcClient _rpcClient;
            _rpcClient = new DiscordRpcClient("856483672458919987", autoEvents: true);
            _rpcClient.RegisterUriScheme();
            _rpcClient.Initialize();
            _rpcClient.SetPresence(new RichPresence()
            {
                State = "Ник: " + API.GetPlayerNameByIDEx(API.GetPlayerId()) + " [" + API.GetPlayerId() + "]",
                Details = "Играет в Perfect CRMP",
                Assets = new Assets()
                {
                    LargeImageKey = "betag0gcxo8_1_",
                    LargeImageText = "perfect-crmp.ru",
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
