using Strategies.Interfaces;

namespace Domain {
    public class RubberDuck : Duck
    {
        public RubberDuck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) 
        : base(flyBehaviour, quackBehaviour)
        {
        }
    }
}