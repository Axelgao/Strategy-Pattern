using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5DuckClassLibrary
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public abstract string Display();

        public string PerformFly()
        {
            return _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public string PerformQuack()
        {
            return _quackBehavior.Quack();
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }
    }
}
