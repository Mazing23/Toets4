﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catan
{
    public class Gun : Weapon
    {
        public override int Damage { get; }

        public Gun(string name) : base(name)
        {

        }

        public override void DoDamage()
        {
            base.DoDamage();
        }
    }
}
