// See https://aka.ms/new-console-template for more information

using DesignPattern;
using DesignPattern.Strategy;

Duck rubberDuck = new RubberDuck();
rubberDuck.PerformQuack();
rubberDuck.PerformFly();

rubberDuck.setFlyBehavior(new FlyRocketPowered());
rubberDuck.PerformFly();
