// See https://aka.ms/new-console-template for more information

using DesignPattern;

Duck rubberDuck = new RubberDuck();
rubberDuck.PerformQuack();
rubberDuck.PerformFly();

rubberDuck.setFlyBehavior(new FlyRocketPowered());
rubberDuck.PerformFly();
