using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Catan
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : UserControl
    {

        Game currentGame;
        public GameWindow() {
            InitializeComponent();
        }
        private void ButtonMoveLeft_Click(object sender, RoutedEventArgs e)
        {
            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(3);
                RefreshLabels();
            }
        }

        private void ButtonMoveup_Click(object sender, RoutedEventArgs e)
        {
            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(0);
                RefreshLabels();
            }
        }

        private void ButtonMoveRight_Click(object sender, RoutedEventArgs e)
        {
            if(currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(3);
                RefreshLabels();
            }
           
        }

        private void ButtonMoveDown_Click(object sender, RoutedEventArgs e)
        {
            if (currentGame.MovesLeft > 0)
            {
                currentGame.MovePlayer(1);
                RefreshLabels();
            }
        }
        private void EquipWeapon_Click(object sender, RoutedEventArgs e)
        {
            currentGame.Player.EquipItem(listboxWeapons.SelectedItem as Item);
            RefreshLabels();
        }

        private void EquipClothes_Click(object sender, RoutedEventArgs e)
        {
            currentGame.Player.EquipItem(listboxClothes.SelectedItem as Item);
            RefreshLabels();
        }
        private void ButtenTakeResources_Click(object sender, RoutedEventArgs e)
        {
            currentGame.takeResources();
            RefreshLabels();
            RefreshListbox();
        }

        private void ButtonNextTurn_Click(object sender, RoutedEventArgs e)
        {
            currentGame.NextTurn();
            RefreshLabels();
        }

        private void ButtonLoadGame_Click(object sender, RoutedEventArgs e)
        {
            currentGame.SaveGame(currentGame);
            //Nog implementeren
        }

        private void ButtonSaveGame_Click(object sender, RoutedEventArgs e)
        {
            string gameDirectory = "";
            currentGame = currentGame.LoadGame(gameDirectory);
            //Nog implementeren
        }

        private void buttonNewGame_click(object sender, RoutedEventArgs e)
        {
            Game newGame = new Game("");
            currentGame = newGame;
            RefreshLabels();
            RefreshListbox();
        }

        private void RefreshListbox()
        {
            listboxClothes.Items.Clear();
            listboxWeapons.Items.Clear();
            listboxResources.Items.Clear();
            Dictionary<Resource, int> Resources = currentGame.Player.Resources;
            foreach(KeyValuePair<Resource, int > r in Resources)
            {
                listboxResources.Items.Add(r);
            }

            List<Item> items = currentGame.Player.Items;
            foreach(Item i in items)
            {
                if(i is Weapon)
                {
                    listboxWeapons.Items.Add(i);
                }
                if(i is Clothing)
                {
                    listboxClothes.Items.Add(i);
                }
            }

       }

        private void RefreshLabels()
        {
            if(currentGame.MovesLeft == 0)
            {
                lblMovesLeft.Content = "No moves left.";
            }
            else
            {
                lblMovesLeft.Content = currentGame.MovesLeft.ToString() + "Moves left.";
            }
            
            lblTurnsLeft.Content = currentGame.TurnsLeft.ToString() + "Turns left.";
            WorldTile currentTile = currentGame.currentTile();
            if(currentTile.Resource != null)
            {
                lblResourcesOnThisLand.Content = currentTile.resourceAmount.ToString() + currentTile.Item.ToString() + "on this tile.";
            }
            else
            {
                lblResourcesOnThisLand.Content = "No resource on this tile.";
            }

            if (currentTile.Item != null)
            {
                lblItemsOnThisLand.Content = currentTile.Item.ToString() + "on this tile.";
            }
            else
            {
                lblItemsOnThisLand.Content = "No item on this tile.";
            }
            lblHealthPoints.Content = currentGame.Player.Health.ToString() + "health points left.";
            lblEquipedWeapon.Content = currentGame.Player.EquipedItem.ToString() + "equipped.";
            lblEquipedClothing.Content = currentGame.Player.EquipedClothes.ToString() + "equipped.";
            lblHomeCitizens.Content = currentGame.Home.Citizens.ToString() + "in your hometown.";
            lblHomeHealth.Content = currentGame.Home.Health.ToString() + "healthpoints";
        }
        private void refreshMapDrawing()
        {
            gridMap.ShowGridLines = true;
        }
    }
}
