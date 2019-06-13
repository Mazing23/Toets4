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

            checkBoxes = new CheckBox[10, 10];
            updateMap();
            RefreshLabels();
            RefreshListbox();
            currentGame.Home.AddDefense(30);
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
           // Dictionary<string, Item> playerInventory = currentGame.Player.Items;
            if (currentGame.MovesLeft == 0)
            {
                lblMovesLeft.Text = "No moves left.";
            }
            else
            {
                lblMovesLeft.Text = currentGame.MovesLeft.ToString() + " moves left.";
            }

            lblTurnsLeft.Text = currentGame.TurnsLeft.ToString() + " turns left.";

            if (currentGame.CurrentTile() is ExploreTile)
            {
                var tileToExplore = currentGame.CurrentTile() as ExploreTile;
                checkBoxes[tileToExplore.posX, tileToExplore.posY].CheckState = CheckState.Indeterminate;
                
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

            else if (currentGame.CurrentTile() is HomeTile)
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


            switch (currentGame.MovePlayer(0))
            {
                case -1:
                    MessageBox.Show("Can't go in this rough forrest");
                    break;
                case 0:
                    MessageBox.Show("No moves left!");
                    break;
                case 1:
                    RefreshLabels();
                    break;
            }
        }

        private void butRight_Click(object sender, EventArgs e)
        {

            switch (currentGame.MovePlayer(3))
            {
                case -1:
                    MessageBox.Show("Can't go in this rough forrest");
                    break;
                case 0:
                    MessageBox.Show("No moves left!");
                    break;
                case 1:
                    RefreshLabels();
                    break;
            }
        }

        private void butDown_Click(object sender, EventArgs e)
        {

            switch (currentGame.MovePlayer(1))
            {
                case -1:
                    MessageBox.Show("Can't go in this rough forrest");
                    break;
                case 0:
                    MessageBox.Show("No moves left!");
                    break;
                case 1:
                    RefreshLabels();
                    break;
            }
        }

        private void butLeft_Click(object sender, EventArgs e)
        {

            switch (currentGame.MovePlayer(2))
            {
                case -1:
                    MessageBox.Show("Can't go in this rough forrest");
                    break;
                case 0:
                    MessageBox.Show("No moves left!");
                    break;
                case 1:
                    RefreshLabels();
                    break;
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
                    checkBoxes[currentGame.Player.posX, currentGame.Player.posY].BackColor = Color.Purple;
                    RefreshLabels();
                    RefreshListbox();
                    break;
                case 3:
                    checkBoxes[currentGame.Player.posX, currentGame.Player.posY].BackColor = Color.Purple;
                    RefreshLabels();
                    RefreshListbox();
                    encounterEnemy();
                    break;
            }
            updateMap();
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
                string newName = Interaction.InputBox("Enter new name for game:", "New Game", "No Name", -1, -1);
                Player newPlayer = new Player(newName);
                Game newGame = new Game(newPlayer, 30);
                currentGame = newGame;
                RefreshLabels();
                RefreshListbox();
                updateMap();
            }
        }

        private void butNextTurn_Click(object sender, EventArgs e)
        {
            if (currentGame.NextTurn() == 1)
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
                RefreshLabels();
            }
            Console.WriteLine("Item equip buttin item = " + itemToEquip.ToString());

        }

        private void butEquipClothes_Click(object sender, EventArgs e)
        {
            currentGame.Player.EquipItem(listBoxClothes.SelectedItem as Item);
            RefreshLabels();

        }

        private void updateMap()
        {
            int startingX = 25;
            int startingY = 25;

            foreach (WorldTile t in currentGame.Map)
            {
                checkBoxes[t.posX, t.posY] = new CheckBox();
                groupBoxMap.Controls.Add(checkBoxes[t.posX, t.posY]);
                checkBoxes[t.posX, t.posY].Width = 15;
                checkBoxes[t.posX, t.posY].Height = 15;
                checkBoxes[t.posX, t.posY].Anchor = (AnchorStyles.Left | AnchorStyles.Top);
                checkBoxes[t.posX, t.posY].Location = new Point((t.posX * 20) + startingX, (t.posY * 20) + startingY);
                checkBoxes[t.posX, t.posY].Visible = true;
                checkBoxes[t.posX, t.posY].Show();
                if (t is HomeTile)
                {
                    checkBoxes[t.posX, t.posY].BackColor = Color.Green;
                    checkBoxes[t.posX, t.posY].Checked = true;
                }

                else if (t is ExploreTile)
                {
                    ExploreTile f = t as ExploreTile;
                 
                        switch (f.Resource.Name)
                        {
                            case "Wood":
                                checkBoxes[t.posX, t.posY].BackColor = Color.SaddleBrown;
                                break;

                            case "Iron":
                                checkBoxes[t.posX, t.posY].BackColor = Color.Silver;
                                break;

                            case "Grain":
                                checkBoxes[t.posX, t.posY].BackColor = Color.Yellow;
                                break;

                            case "Wool":
                                checkBoxes[t.posX, t.posY].BackColor = Color.White;
                                break;

                            case "Stone":
                                checkBoxes[t.posX, t.posY].BackColor = Color.DarkGray;
                                break;
                        }

                 
                }
            }
        }
        
        private void encounterEnemy()
        {
            Random rand = new Random();
            Enemy enemyToFight = currentGame.GiveNewEnemy();
            if (enemyToFight == null)
            {
                switch (rand.Next(0, 2))
                {
                    case 0:
                        MessageBox.Show("You stepped on a mouse... Poor thing.");
                        break;
                    case 1:
                        MessageBox.Show("You got spooked by a mouse, you sissy");
                        break;
                    case 2:
                        MessageBox.Show("You tripped over a tree branch. Lift your feet up!");
                        break;
                }
            }
            else
            {
                SimpleFightForm fightForm = new SimpleFightForm(currentGame.Player, enemyToFight);
                
                if (fightForm.ShowDialog() == DialogResult.OK)
                {
                    currentGame.Player.setHealth(fightForm.Player.Health);                  
                }
                fightForm.Dispose();

            }

            if (currentGame.Player.Health <= 0)
            {
                if (MessageBox.Show("You died! Do you want to start a new game? Yes or no", "WARNING!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string newName = Interaction.InputBox("Enter new name for game:", "New Game", "No Name", -1, -1);
                    Player newPlayer = new Player(newName);
                    Game newGame = new Game(newPlayer, 30);
                    currentGame = newGame;
                    foreach(CheckBox c in checkBoxes)
                    {
                        c.Dispose();
                    }
                    RefreshLabels();
                    RefreshListbox();
                    updateMap();
                }
                else
                {
                    this.Close();
                    this.Dispose();
                }
            }

            RefreshLabels();
        }
    }
}

