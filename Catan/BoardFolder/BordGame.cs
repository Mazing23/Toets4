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
            InitializeComponent();
            ofd = new OpenFileDialog();
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
                
            }

            checkBoxes = new CheckBox[10,10];
            generateMap();
            RefreshLabels();
            RefreshListbox();
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
           // checkBoxes[currentGame.Player.posX, currentGame.Player.posY].CheckState = CheckState.Indeterminate;

            if (currentTile is ExploreTile)
            {
                var tileToExplore = currentTile as ExploreTile;
                if (tileToExplore.isLooted)
                {
                    lblItemOnThisLand.Text = "You have already looted these items";
                    lblResourcesOnThisTile.Text = "You have already looted these items";
                }
                else
                {
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
            }

            else if(currentTile is HomeTile)
            {
                lblResourcesOnThisTile.Text = "This is your home, no resources to loot here.";
                lblItemOnThisLand.Text = "This is your home, no items to loot here.";
            }



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

            lblHealthPoints.Text = currentGame.Player.Health.ToString() + " health points left.";
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

            if (currentGame.MovePlayer(2) == 1)
            {
                RefreshLabels();
            }
            else
            {
                MessageBox.Show("No moves left!");
            }
        }

        private void butRight_Click(object sender, EventArgs e)
        {
            if (currentGame.MovePlayer(1) == 1)
            {
                RefreshLabels();
            }
            else
            {
                MessageBox.Show("No moves left!");
            }
        }

        private void butDown_Click(object sender, EventArgs e)
        {

            if (currentGame.MovePlayer(3) == 1)
            {
                RefreshLabels();
            }
            else
            {
                MessageBox.Show("No moves left!");
            }
        }

        private void butLeft_Click(object sender, EventArgs e)
        {

             if (currentGame.MovePlayer(0) == 1)
             {
                RefreshLabels();
             }
             else
             {
                 MessageBox.Show("No moves left!");
             }
        }

        private void butHarvest_Click(object sender, EventArgs e)
        {
            switch (currentGame.TakeResources())
            {
                case 0:
                    MessageBox.Show("No moves left!");
                    break;
                case 1:
                    MessageBox.Show("No items to loot at home!");
                    break;
                case 2:
                    RefreshLabels();
                    RefreshListbox();
                    break;
            }
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
           if(currentGame.NextTurn() == 1)
            {
                RefreshLabels();
            }
            else
            {
                MessageBox.Show("No turns left thanks for playing!");
            }
        }

        private void butEquipWeapons_Click(object sender, EventArgs e)
        {
            //currentGame.Player.EquipItem(listBoxWeapons.SelectedItem as Item);
            Item itemToEquip = listBoxWeapons.SelectedItem as Item;
            if (currentGame.Player.EquipItem(itemToEquip))
            {
                MessageBox.Show("Equipped!");
            }
            Console.WriteLine("Item equip buttin item = " + itemToEquip.ToString());
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

            WorldTile[,] tempworld = currentGame.Map;

            for (int i = 0; i < 10;)
            {
                if (i == 0)
                {
                    startingY = 25;
                }
                if ((i - lastX) != 0)
                {
                    lastX = i;
                    startingX += 15;
                }

               


                for (int j = 0; j < 10;)
                {
                    if (j == 0)
                    {
                        startingX = 25;
                    }
                    if ((j - lastY) != 0)
                    {
                        lastY = j;
                        startingY += 15;
                    }
                    checkBoxes[i, j] = new CheckBox();
                    groupBoxMap.Controls.Add(checkBoxes[i, j]);
                    checkBoxes[i, j].Width = 15;
                    checkBoxes[i, j].Height = 15;
                    checkBoxes[i, j].Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                    checkBoxes[i, j].Location = new Point(startingY, startingX);
                    checkBoxes[i, j].Visible = true;
                    checkBoxes[i, j].Show();
                    if ((i == 4 || i == 5) && (j == 6 || j == 5))
                    {
                        checkBoxes[i, j].BackColor = Color.Green;
                        checkBoxes[i, j].Checked = true;
                    }
                    else
                    {

                    }
                    j++;
                }
                i++;
            }


            //foreach (WorldTile t in currentGame.Map)
            //{
            //    if (t.posY == 0)
            //    {
            //        startingY = 25;
            //    }

            //    if (t.posX == 0)
            //    {
            //        startingX = 25;
            //    }

            //    checkBoxes[t.posX, t.posY] = new CheckBox();
            //    groupBoxMap.Controls.Add(checkBoxes[t.posX, t.posY]);
            //    checkBoxes[t.posX, t.posY].Width = 15;
            //    checkBoxes[t.posX, t.posY].Height = 15;
            //    checkBoxes[t.posX, t.posY].Anchor = (AnchorStyles.Left | AnchorStyles.Top);
            //    checkBoxes[t.posX, t.posY].Location = new Point(startingY, startingX);
            //    checkBoxes[t.posX, t.posY].Visible = true;
            //    checkBoxes[t.posX, t.posY].Show();
            //    if (t is HomeTile)
            //    {
            //        checkBoxes[t.posX,
            //            t.posY].BackColor = Color.Green;
            //        checkBoxes[t.posX, t.posY].Checked = true;
            //    }

            //    else if (t is ExploreTile)
            //    {
            //        ExploreTile f = t as ExploreTile;
            //        switch (f.Resource.Name)
            //        {
            //            case "Wood":
            //                checkBoxes[t.posX, t.posY].BackColor = Color.SaddleBrown;
            //                break;

            //            case "Iron":
            //                checkBoxes[t.posX, t.posY].BackColor = Color.Silver;
            //                break;

            //            case "Grain":
            //                checkBoxes[t.posX, t.posY].BackColor = Color.Yellow;
            //                break;

            //            case "Wool":
            //                checkBoxes[t.posX, t.posY].BackColor = Color.White;
            //                break;

            //            case "Stone":
            //                checkBoxes[t.posX, t.posY].BackColor = Color.DarkGray;
            //                break;
            //        }
            //    }

            //    if ((t.posX - lastX) != 0)
            //    {
            //        lastX = t.posX;
            //        startingX += 15;
            //    }

            //    if ((t.posY - lastY) != 0)
            //    {
            //        lastY = t.posY;
            //        startingY += 15;
            //    }


            //}
        }

    }
}
