using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T5DuckClassLibrary
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new NormalQuack();
        }

        public override string Display()
        {
            return "I'm mallard duck";
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new MuteQuack();
        }

        public override string Display()
        {
            return "I'm Rubber duck";
        }
    }

    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }

        public override string Display()
        {
            return "I'm Red Head duck";
        }
    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Squeak();
        }

        public override string Display()
        {
            return "I'm Decoy duck";
        }
    }
}