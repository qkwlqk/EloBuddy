﻿using AutoBuddy.MainLogics;
using EloBuddy;

namespace AutoBuddy.MyChampLogic
{
    internal interface IChampLogic
    {
        int[] skillSequence { get; }
        LogicSelector Logic { get; set; }
        string ShopSequence { get; }
        void Harass(AIHeroClient target);
        void Survi();
        void Combo(AIHeroClient target);
    }
}