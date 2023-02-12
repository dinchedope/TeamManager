using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreatePlayer;

namespace TeamManager
{
    public partial class Form1 : Form
    {
        List<Player> playerList = new List<Player>();
        List<FabricCreatePlayer> playerFabrics = new List<FabricCreatePlayer>();
        public Form1()
        {
            InitializeComponent();
            playerFabrics.Add(new CreateDefender());
            playerFabrics.Add(new CreateForward());
            playerFabrics.Add(new CreateGoalkeeper());
            playerFabrics.Add(new CreateMidfielder());

            for(int i = 0; i < playerFabrics.Count(); i++)
            {
                comboBox1.Items.Insert(i, playerFabrics[i].GetFabricName());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Characteristics playerCharacteristics = new Characteristics();
            try
            {
                playerCharacteristics.Pac = Convert.ToInt32(Pactb.Text);
                playerCharacteristics.Sho = Convert.ToInt32(Shotb.Text);
                playerCharacteristics.Pas = Convert.ToInt32(Pastb.Text);
                playerCharacteristics.Dri = Convert.ToInt32(Dritb.Text);
                playerCharacteristics.Def = Convert.ToInt32(Deftb.Text);
                playerCharacteristics.Phy = Convert.ToInt32(Phytb.Text);
            }
            catch (Exception ex)
            {

            }
            playerList.Add(playerFabrics[comboBox1.SelectedIndex].CreatePlayer(playerCharacteristics));

            comboBox2.Items.Add(playerList[playerList.Count() - 1]);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pactb.Text = playerList[comboBox2.SelectedIndex].GetCharacteristics().Pac.ToString();
            Shotb.Text = playerList[comboBox2.SelectedIndex].GetCharacteristics().Sho.ToString();
            Pastb.Text = playerList[comboBox2.SelectedIndex].GetCharacteristics().Pas.ToString();
            Dritb.Text = playerList[comboBox2.SelectedIndex].GetCharacteristics().Dri.ToString();
            Deftb.Text = playerList[comboBox2.SelectedIndex].GetCharacteristics().Def.ToString();
            Phytb.Text = playerList[comboBox2.SelectedIndex].GetCharacteristics().Phy.ToString();
        }
    }
}
