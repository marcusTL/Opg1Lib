﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Opg1Lib
{
    public class Cykel
    {
        private int _id;
        private string _color;
        private int _price;
        private int _gear;

        public Cykel()
        {
        }

        public Cykel(int id, string color, int price, int gear)
        {
            Id = id;
            Color = color;
            Price = price;
            Gear = gear;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        

        public string Color
        {
            get => _color;
            set
            {
                if (value.Length < 1) {throw new ArgumentOutOfRangeException();}
                _color = value;
            }
            
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) { throw new ArgumentOutOfRangeException();}
                _price = value;
            }
        }

        public int Gear
        {
            get => _gear;
            set
            {
                if (value < 3 || value > 32) { throw new ArgumentOutOfRangeException();}
                _gear = value;
            }
        }
    }
}
