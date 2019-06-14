using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
        SaveFileDialog sfd;
        CheckBox[,] checkBoxes;
        GameSave save;

        public BordGame()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            save = new GameSave();
            if (MessageBox.Show("Do you want to resume a previous game?", "WARNING!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileDirectory = ofd.FileName;
                    try
                    {
                        currentGame = save.LoadGame(fileDirectory);
                    }
                    catch (SerializationException ex)
                    {
                        MessageBox.Show("Something went wrong with loading the file: " + ex.Message);
                    }
                    catch(IOException ex)
                    {
                        MessageBox.Show("Couldn't read: " + ex.Message);
                    }
                }
                else
                {
                    PromptNewGame();
                }
            }
            else
            {
                PromptNewGame();
            }

            checkBoxes = new CheckBox[10, 10];
            generateMap();
            RefreshLabels();
            RefreshListbox();
            currentGame.Home.AddDefense(30);
        }
        private void PromptNewGame()
        {
            string newName = Interaction.InputBox("Enter new name for game:", "New Game", "No Name");
            Player newPlayer = new Player(newName);
            Game newGame = new Game(newPlayer, 30);
            currentGame = newGame;
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
            lblName.Text = currentGame.Player.Name;

            if (currentGame.CurrentTile() is ExploreTile)
            {
                var tileToExplore = currentGame.CurrentTile() as ExploreTile;
                if (!tileToExplore.isLooted)
                {
                    checkBoxes[tileToExplore.posX, tileToExplore.posY].CheckState = CheckState.Checked;
                }
                
                if (tileToExplore.isLooted)
                {
                    lblItemOnThisLand.Text = "You have looted these items";
                    lblResourcesOnThisTile.Text = "You have looted these items";
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

            progressBarHealth.Value = currentGame.Player.Health;
            lblNumberOfCitizens.Text = currentGame.Home.Citizens.ToString() + " citizens in your hometown.";
            lblHomeHealth.Text = currentGame.Home.Health.ToString() + " healthpoints";
            
        }

        private void RefreshListbox()
        {
            listBoxClothes.Items.Clear();
            listBoxWeapons.Items.Clear();
            listBoxResources.Items.Clear();
            Dictionary<Resource, int> Resources = currentGame.Player.Resources;
            foreach (KeyValuePair<Resource, int> r in currentGame.Player.Resources)
            {
                listBoxResources.Items.Add(r.ToString());
            }

            List<Item> items = currentGame.Player.Items;
            foreach (Item i in currentGame.Player.Items)
            {
                if (i is Weapon)
                {
                    if (i == currentGame.Player.EquipedWeapon)
                    {
                        listBoxWeapons.Items.Add(i + " Equiped");
                    }
                    else
                    {
                        listBoxWeapons.Items.Add(i);
                    }
                }
                if (i is Clothing)
                {
                    if (i == currentGame.Player.EquipedClothes)
                    {
                        listBoxClothes.Items.Add(i + " Equiped");
                    }
                    else
                    {
                        listBoxClothes.Items.Add(i);
                    }
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
                    MessageBox.Show("You have allready looted this place!");
                    break;
                case 3:
                    RefreshLabels();
                    RefreshListbox();
                    checkBoxes[currentGame.Player.posX, currentGame.Player.posY].CheckState = CheckState.Indeterminate;
                    break;
                case 4:
                    RefreshLabels();
                    RefreshListbox();
                    encounterEnemy();
                    checkBoxes[currentGame.Player.posX, currentGame.Player.posY].CheckState = CheckState.Indeterminate;
                    break;
            }
        }

        private void butLoadGame_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = ofd.FileName;
                try
                {
                    currentGame = save.LoadGame(sourceFile);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show("Something went wrong with loading the file: " + ex.Message);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Couldn't read: " + ex.Message);
                }
            }
        }


        private void butSaveGame_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = sfd.FileName;
                try
                {
                    save.SaveGame(currentGame, sourceFile);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show("Something went wrong with saving the file: " + ex.Message);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Couldn't write: " + ex.Message);
                }
            }

        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start a new game? Yes or no", "WARNING!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                PromptNewGame();
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
            if (listBoxWeapons.SelectedIndex != -1)
            {
                Item itemToEquip = listBoxWeapons.SelectedItem as Item;
                if (currentGame.Player.EquipItem(itemToEquip))
                {
                    MessageBox.Show("Equipped!");
                    RefreshLabels();
                    RefreshListbox();
                }
                Console.WriteLine("Item equip buttin item = " + itemToEquip.ToString());
            }
            else
            {
                MessageBox.Show("Select an item first");
            }

        }

        private void butEquipClothes_Click(object sender, EventArgs e)
        {
            if (listBoxClothes.SelectedIndex != -1)
            {
                Item itemToEquip = listBoxClothes.SelectedItem as Item;
                if (currentGame.Player.EquipItem(itemToEquip))
                {
                    MessageBox.Show("Equipped!");
                    RefreshLabels();
                    RefreshListbox();
                }
                Console.WriteLine("Item equip buttin item = " + itemToEquip.ToString());
            }
            else
            {
                MessageBox.Show("Select an item first");
            }

        }

        private void generateMap()
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
                checkBoxes[t.posX, t.posY].Enabled = false;
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
         
            SimpleFightForm fightForm = new SimpleFightForm(currentGame.Player, enemyToFight);
                
            if (fightForm.ShowDialog() == DialogResult.OK)
            {
             currentGame.Player.setHealth(fightForm.Player.Health);
             enemyToFight = fightForm.Enemy;
            }
            fightForm.Dispose();
            

            if (currentGame.Player.Health <= 0)
            {
                var result = MessageBox.Show("You died! Do you want to start a new game? Yes or no", "WARNING!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                   
                    foreach(CheckBox c in checkBoxes)
                    {
                        c.Dispose();
                    }

                    PromptNewGame();
                    RefreshLabels();
                    RefreshListbox();
                    generateMap();
                }
                else if(result == DialogResult.No)
                {
                    this.Close();
                    this.Dispose();
                    System.Environment.Exit(1);
                }
              
            }
            else if (enemyToFight.Health > 0 || currentGame.Player.Health > 0)
            {
                int damage = rand.Next(0, 30);
                MessageBox.Show("The monster has found your home and did " + damage.ToString() + " damage!");
                currentGame.Home.takeDamage(damage);
            }
            RefreshLabels();
        }
    }
}

