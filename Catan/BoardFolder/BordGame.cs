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

        public BordGame()
        {
            InitializeComponent();
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
                lblMovesLeft.Text = currentGame.MovesLeft.ToString() + "Moves left.";
            }

            lblTurnsLeft.Text = currentGame.TurnsLeft.ToString() + "Turns left.";
            //WorldTile currentTile = currentGame.currentTile();
            //if (currentTile.Resource != null)
            //{
            //    lblResourcesOnThisLand.Text = currentTile.resourceAmount.ToString() + currentTile.Item.ToString() + "on this tile.";
            //}
            //else
            //{
            //    lblResourcesOnThisLand.Text = "No resource on this tile.";
            //}

            //if (currentTile.Item != null)
            //{
            //    lblItemOnThisLand.Text = currentTile.Item.ToString() + "on this tile.";
            //}
            //else
            //{
            //    lblItemOnThisLand.Text = "No item on this tile.";
            //}
            lblHealthPoints.Text = currentGame.Player.Health.ToString() + "health points left.";
            lblEquippedWeapon.Text = currentGame.Player.EquipedItem.ToString() + "equipped.";
            lblEquippedClothing.Text = currentGame.Player.EquipedClothes.ToString() + "equipped.";
            lblNumberOfCitizens.Text = currentGame.Home.Citizens.ToString() + "in your hometown.";
            lblHomeHealth.Text = currentGame.Home.Health.ToString() + "healthpoints";

        }

        private void RefreshListbox()
        {
            listBoxClothes.Items.Clear();
            listBoxWeapons.Items.Clear();
            listBoxResources.Items.Clear();
            Dictionary<Resource, int> Resources = currentGame.Player.Resources;
            foreach (KeyValuePair<Resource, int> r in Resources)
            {
                listBoxResources.Items.Add(r);
            }

            List<Item> items = currentGame.Player.Items;
            foreach (Item i in items)
            {
                if (i is Weapon)
                {
                    listBoxWeapons.Items.Add(i);
                }
                if (i is Clothing)
                {
                    listBoxClothes.Items.Add(i);
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
        }

        private void butLeft_Click(object sender, EventArgs e)
        {

            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(2);
                RefreshLabels();
            }
        }

        private void butHarvest_Click(object sender, EventArgs e)
        {
            currentGame.takeResources();
            RefreshLabels();
            RefreshListbox();
        }

        private void butLoadGame_Click(object sender, EventArgs e)
        {
            currentGame.SaveGame(currentGame);
            //Nog implementeren
        }

        private void butSaveGame_Click(object sender, EventArgs e)
        {
            string gameDirectory = "";
            currentGame = currentGame.LoadGame(gameDirectory);
            //Nog implementeren
        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yes or no", "Are you sure you want to start a new game?",
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
    }
}
