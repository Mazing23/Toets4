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
            gridMap.
        }

        private void drawMap()
        {
            // Create the Grid
            Grid myGrid = new Grid();
            myGrid.Width = 400;
            myGrid.Height = 400;
            myGrid.HorizontalAlignment = HorizontalAlignment.Left;
            myGrid.VerticalAlignment = VerticalAlignment.Top;
            myGrid.ShowGridLines = true;

            //De columns maken
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            ColumnDefinition colDef3 = new ColumnDefinition();
            ColumnDefinition colDef4 = new ColumnDefinition();
            ColumnDefinition colDef5 = new ColumnDefinition();
            ColumnDefinition colDef6 = new ColumnDefinition();
            ColumnDefinition colDef7 = new ColumnDefinition();
            ColumnDefinition colDef8 = new ColumnDefinition();
            ColumnDefinition colDef9 = new ColumnDefinition();
            ColumnDefinition colDef10 = new ColumnDefinition();
            myGrid.ColumnDefinitions.Add(colDef1);
            myGrid.ColumnDefinitions.Add(colDef2);
            myGrid.ColumnDefinitions.Add(colDef3);
            myGrid.ColumnDefinitions.Add(colDef4);
            myGrid.ColumnDefinitions.Add(colDef5);
            myGrid.ColumnDefinitions.Add(colDef6);
            myGrid.ColumnDefinitions.Add(colDef7);
            myGrid.ColumnDefinitions.Add(colDef8);
            myGrid.ColumnDefinitions.Add(colDef9);
            myGrid.ColumnDefinitions.Add(colDef10);

            //De rows maken
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            RowDefinition rowDef4 = new RowDefinition();
            myGrid.RowDefinitions.Add(rowDef1);
            myGrid.RowDefinitions.Add(rowDef2);
            myGrid.RowDefinitions.Add(rowDef3);
            myGrid.RowDefinitions.Add(rowDef4);

        }
    }
}
