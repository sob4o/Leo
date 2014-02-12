﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Bunker :GameObject, ITower
    {
        private int damage = 40;
        private int price = 60;
        private char sign = '%';
        private char[,] sizeOfElement = new char[2, 2];
        private Color color = Color.Yellow;

        public override UpperLeftPoint UpperLeftPoint { get; set; }

        public override char[,] SizeOfElement
        {
            get { return this.sizeOfElement; }
        }

        public override char Sign
        {
            get { return this.sign; }
        }

        public override Color Color
        {
            get { return this.color; }
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public int Price
        {
            get { return this.price; }
        }
    }
}
