using Domain;
using  Strategies.Implementations;

Duck rubberDuck = new RubberDuck(new FlyNoWay(),new Squeak());
Duck mallardDuck = new MallardDuck(new FlyWithWings(), new NormalQuack());

rubberDuck.PerformFly();
mallardDuck.PerformFly();

rubberDuck.PerformQuack();
mallardDuck.PerformQuack();