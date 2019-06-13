using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Weapon : Item
    {
        Random rand = new Random();

        public int Range { get; set; }
        public override int Damage { get; }
        public override string Name
        {
            get
            {
                string outputname = "";
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                for (int i = 0; i < rand.Next(1, 20); i++) { outputname += chars[rand.Next(52)]; }
                return outputname;
            }
        }

        public Weapon() : base()
        {

        }

        public string NameMaking()
        {
            string outputname = Name;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < rand.Next(1, 20); i++) { outputname += chars[rand.Next(52)]; }
            return outputname;
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }

    }
}