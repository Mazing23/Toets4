using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catan
{
    public partial class SimpleFightForm : Form
    {
        public Player Player { get; private set; }
        public Enemy Enemy { get; private set; }
        public SimpleFightForm( Player player, Enemy enemy)
        {
            InitializeComponent();
            Player = player;
            Enemy = enemy;
            updateText();
        }

        private void updateText()
        {
            if(Player.EquipedClothes == null)
            {
                lblEquipedClothing.Text = "You are naked!";
            }
            else
            {
                lblEquipedClothing.Text = Player.EquipedClothes.Name;
            }

            if(Player.EquipedWeapon == null)
            {
                lblEquipedWeapon.Text = "You are fighting bare handed!";
            }
            else
            {
                lblEquipedWeapon.Text = Player.EquipedWeapon.Name;
            }
            progressBarHealth.Value = Player.Health;
        }
    }
}
