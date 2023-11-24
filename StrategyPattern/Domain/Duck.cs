using Strategies.Interfaces;

namespace Domain {
    public abstract class Duck {
        IFlyBehaviour flyBehaviour;
        IQuackBehaviour quackBehaviour;

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            this.flyBehaviour = flyBehaviour;
            this.quackBehaviour = quackBehaviour;
        }

        public void PerformFly() {
            flyBehaviour.Fly();
        }

        public void PerformQuack() {
            quackBehaviour.Quack();
        }
    }
}
