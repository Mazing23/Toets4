using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Sword : Weapon
    {
        Random rand = new Random();
        private string name;

        public override int Damage
        {
            get
            {
                if (Name.Length > 50) return 50;
                if (Name.Length - 5 <= 0) return rand.Next(1, Name.Length);
                return rand.Next((Name.Length - 5), Name.Length);
            }
        }

        public override string Name { get
            {
                return name;
            }
        }

        public Sword() : base()
        {
        }

        private string NameMaking()
        {
            string outputname = base.Name;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < rand.Next(1, 50); i++) { outputname += chars[rand.Next(52)]; }
            return outputname;
        }

        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }

    }
}
