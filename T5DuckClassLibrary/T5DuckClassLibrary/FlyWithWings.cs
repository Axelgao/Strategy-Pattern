using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5DuckClassLibrary
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I can fly";
        }
    }
}