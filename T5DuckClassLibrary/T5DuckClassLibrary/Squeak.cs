﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5DuckClassLibrary
{
    public class Squeak : IQuackBehavior
    {
        public string Quack()
        {
            return "I can squeak";
        }
    }
}