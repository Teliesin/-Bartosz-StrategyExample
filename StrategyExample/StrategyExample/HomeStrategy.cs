﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class HomeStrategy : IIntroduceStrategy
    {
        public string IntroduceYourself()
        {
            return "Jestem mężem i synem";
        }
    }
}