﻿using System;
using System.Collections.Generic;
using System.Text;
using ILogic.ItemFolder;

namespace Logic.ItemsFolder
{
    public class SpecialAttack : IspecialAttack
    {
        public string Name { get; set; }
        public string AttackType { get; set; }
        public int AttackMutiplier { get; set; }
        public int BaseAccuracy { get; set; }
    }
}
