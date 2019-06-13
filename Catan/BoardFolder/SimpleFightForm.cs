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
        Random rand;
        public SimpleFightForm( Player player, Enemy enemy)
        {
            InitializeComponent();
            Player = player;
            Enemy = enemy;
            updateText();
            rand = new Random();
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
            progressBarHealthYou.Value = Player.Health;
            progressBarHealthEnemy.Value = Enemy.Health;
            lblEnemyDamage.Text = "Enemy deals "+ Enemy.Damage.ToString() + "Damage";
            lblEnemyName.Text = Enemy.Name;
            lblYouName.Text = Player.Name;
        }

        private void buttonFight_Click(object sender, EventArgs e)
        {
            if (Enemy.Health > 0)
            {
                if(Player.EquipedWeapon == null)
                {
                    MessageBox.Show("You strike him with your weak fist!");
                }
                else
                {
                    MessageBox.Show("You hit the enemy with your" + Player.EquipedWeapon.Name);
                }
                Enemy.TakeDamage(Player.EquipedWeapon);
                Player.TakeDamage(Enemy.Damage);
                if(Enemy.Health <= 0)
                {
                    MessageBox.Show("You defeated the enemy!");
                    this.Close();
                }
                else if(Player.Health <= 0)
                {
                    this.Close();
                }
                else
                {
                    updateText();
                }

            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if(rand.Next(0,10) > 6)
            {
                MessageBox.Show("You ran away succesfuly");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("The enemy blocked your way and hits you");
                Player.TakeDamage(Enemy.Damage);
            }
            updateText();
        }
    }
}
