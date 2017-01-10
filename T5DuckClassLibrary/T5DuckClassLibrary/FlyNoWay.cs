using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5DuckClassLibrary
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I cannot fly";
        }
    }
}