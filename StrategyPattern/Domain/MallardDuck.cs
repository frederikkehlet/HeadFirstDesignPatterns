using Strategies.Interfaces;

namespace Domain {
    public class MallardDuck : Duck
    {
        public MallardDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) 
        : base(flyBehaviour, quackBehaviour)
        {
        }
    }
}

