﻿using System;
using System.Collections.Generic;
using System.Text;
using ILogic.ItemFolder;

namespace Logic.ItemsFolder
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int SpecialAttack { get; set; }
        public int Agility { get; set; }
        public int Price { get; set; }
    }
}
