using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Catan
{
    public partial class BordGame : Form
    {
        Game currentGame;
        OpenFileDialog ofd;
        CheckBox[,] checkBoxes;

        public BordGame()
        {
            ofd = new OpenFileDialog();
            InitializeComponent();
            if (MessageBox.Show("Do you want to resume a previous game?", "WARNING!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileDirectory = ofd.FileName;
                    currentGame.LoadGame(fileDirectory);
                }
            }
            else
            {
                string newName = Interaction.InputBox("Enter new name for game:", "New Game", "No Name", -1, -1);
                Player newPlayer = new Player(newName);
                Game newGame = new Game(newPlayer, 30);
                currentGame = newGame;
                RefreshLabels();
                RefreshListbox();
            }
            checkBoxes = new CheckBox[10,10];
            generateMap();
        }

        private void SaveGame(Game game)
        {
            try
            {
                // serialize gamesave
                // serialize game
            }
            catch
            {

            }
        }

        private void LoadGame()
        {
            try
            {
                // deserialize gamesave
                // deserialize game
                // Game = game
            }
            catch
            {

            }
        }

        private void RefreshLabels()
        {
            if (currentGame.MovesLeft == 0)
            {
                lblMovesLeft.Text = "No moves left.";
            }
            else
            {
                lblMovesLeft.Text = currentGame.MovesLeft.ToString() + " moves left.";
            }

            lblTurnsLeft.Text = currentGame.TurnsLeft.ToString() + " turns left.";


            WorldTile currentTile = currentGame.CurrentTile();

            if (currentTile is ExploreTile)
            {
                var tileToExplore = currentTile as ExploreTile;
                if (tileToExplore.Resource != null)
                {
                    lblResourcesOnThisTile.Text = tileToExplore.resourceAmount.ToString() + " " + tileToExplore.Resource.Name.ToString() + " on this tile.";
                }
                else
                {
                    lblResourcesOnThisTile.Text = "No resource on this tile.";
                }

                if (tileToExplore.Item != null)
                {
                    lblItemOnThisLand.Text = tileToExplore.Item.Name.ToString() + " on this tile.";
                }
                else
                {
                    lblItemOnThisLand.Text = "No item on this tile.";
                }
            }

            else if(currentTile is HomeTile)
            {
                lblResourcesOnThisTile.Text = "This is your home, no resources here.";
                lblItemOnThisLand.Text = "This is your home, no items here.";
            }
            
            lblHealthPoints.Text = currentGame.Player.Health.ToString() + " health points left.";
            if (currentGame.Player.EquipedItem != null)
            {
                lblEquippedWeapon.Text = currentGame.Player.EquipedItem.ToString() + " equipped.";
            }
            else
            {
                lblEquippedWeapon.Text = "No weapon equipped.";
            }

            if (currentGame.Player.EquipedClothes != null)
            {
                lblClothesEquipped.Text = currentGame.Player.EquipedClothes.ToString() + " equipped.";
            }
            else
            {
                lblClothesEquipped.Text = "No clothing equipped.";
            }
            lblNumberOfCitizens.Text = currentGame.Home.Citizens.ToString() + " citizens in your hometown.";
            lblHomeHealth.Text = currentGame.Home.Health.ToString() + " healthpoints";
            lblPlayerName.Text = currentGame.Player.Name.ToString() + " :";


            //label voor debuggen
            lblPosy.Text = "Pos y = " + currentGame.Player.posY.ToString();
            lblPosx.Text = "Pos x = " + currentGame.Player.posX.ToString();

        }

        private void RefreshListbox()
        {
            listBoxClothes.Items.Clear();
            listBoxWeapons.Items.Clear();
            listBoxResources.Items.Clear();
            Dictionary<Resource, int> Resources = currentGame.Player.Resources;
            foreach (KeyValuePair<Resource, int> r in Resources)
            {
                listBoxResources.Items.Add(r.ToString());
            }

            List<Item> items = currentGame.Player.Items;
            foreach (Item i in items)
            {
                if (i is Weapon)
                {
                    listBoxWeapons.Items.Add(i.ToString());
                }
                if (i is Clothing)
                {
                    listBoxClothes.Items.Add(i.ToString());
                }
            }

        }

        private void butUp_Click(object sender, EventArgs e)
        {

            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(0);
                RefreshLabels();
            }
        }

        private void butRight_Click(object sender, EventArgs e)
        {
            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(3);
                RefreshLabels();
            }
        }

        private void butDown_Click(object sender, EventArgs e)
        {

            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(1);
                RefreshLabels();
            }
            else if(currentGame.MovesLeft == 0)
            {
                MessageBox.Show("No moves left!");
            }
        }

        private void butLeft_Click(object sender, EventArgs e)
        {

            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(Left);
                RefreshLabels();
            }
        }

        private void butHarvest_Click(object sender, EventArgs e)
        {
            currentGame.TakeResources();
            RefreshLabels();
            RefreshListbox();
        }

        private void butLoadGame_Click(object sender, EventArgs e)
        {
          
            string gameDirectory = "";
            currentGame = currentGame.LoadGame(gameDirectory);
            //Nog implementeren

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = ofd.FileName;
            }
        }

        private void butSaveGame_Click(object sender, EventArgs e)
        {
            currentGame.SaveGame(currentGame);
            //Nog implementeren]
        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new game? Yes or no", "WARNING!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string newName =Interaction.InputBox("Enter new name for game:", "New Game", "No Name", -1, -1);
                Player newPlayer = new Player(newName);
                Game newGame = new Game(newPlayer, 30);
                currentGame = newGame;
                RefreshLabels();
                RefreshListbox();
            }
        }

        private void butNextTurn_Click(object sender, EventArgs e)
        {
            currentGame.NextTurn();
            RefreshLabels();
        }

        private void butEquipWeapons_Click(object sender, EventArgs e)
        {
            currentGame.Player.EquipItem(listBoxWeapons.SelectedItem as Item);
            RefreshLabels();
        }

        private void butEquipClothes_Click(object sender, EventArgs e)
        {
            currentGame.Player.EquipItem(listBoxClothes.SelectedItem as Item);
            RefreshLabels();

        }

        private void generateMap()
        {
            int startingX = 25;
            int startingY = 25;

            int lastX = 0;
            int lastY = 0;

            int Count =0;

            foreach ( WorldTile t in currentGame.Map)
            {
                checkBoxes[t.posX, t.posY] = new CheckBox();
                groupBoxMap.Controls.Add(checkBoxes[t.posX, t.posY]);
                checkBoxes[t.posX, t.posY].Width = 15;
                checkBoxes[t.posX, t.posY].Height = 15;
                checkBoxes[t.posX, t.posY].Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                checkBoxes[t.posX, t.posY].Location = new Point(startingY, startingX);
                checkBoxes[t.posX, t.posY].Visible = true;
                checkBoxes[t.posX, t.posY].Show();
                if (t is HomeTile)
                {
                    checkBoxes[t.posX, t.posY].BackColor = Color.Green;
                    checkBoxes[t.posX, t.posY].Checked = true;

                    Count += 1;
                }
                else if(t is ExploreTile)
                {
                    checkBoxes[t.posX, t.posY].BackColor = Color.Red;
                }

                if((t.posX - lastX) != 0)
                {
                    lastX = t.posX;
                    startingX += 20;
                }

                if ((t.posY - lastY) != 0)
                {
                    lastY = t.posY;
                    startingY += 20;
                }

                if(t.posY == 0)
                {
                    startingY = 25;
                }

                if (t.posX == 0)
                {
                    startingX = 25;
                }

                Console.Write(t.posX.ToString());
                Console.WriteLine(t.posY.ToString());
            }

            Console.WriteLine(Count.ToString());
        }

        private void updateMap()
        {

        }
       
        private void lblPosx_Click(object sender, EventArgs e)
        {

        }
    }
}
