using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Clothing : Item
    {
        Random rand = new Random();

        public override int Damage
        {
            get
            {
                if (Name.Length > 40) return 40;
                if (Name.Length - 10 <= 0) return rand.Next(1, Name.Length);
                return rand.Next((Name.Length - 10), Name.Length);
            }
        }

        public override string Name { get; set; }

        public Clothing() : base()
        {
            string outputname = Name;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < rand.Next(1, 40); i++) { outputname += chars[rand.Next(52)]; }
            Name = outputname;
        }


        public override string ToString()
        {
            return base.ToString() + " , Damage: " + Damage;
        }
    }
}