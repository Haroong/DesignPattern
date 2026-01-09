using DesignPattern.Factory.Ingredient.Cheese;
using DesignPattern.Factory.Ingredient.Dough;

namespace DesignPattern.Factory.Ingredient;

public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
{
    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Veggies[] CreateVeggies()
    {
        Veggies veggies[] =  {
            new Spinach(), new BlackOlives(), new EggPlant()
        }
        return veggies;
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Clams CreateClams()
    {
        return new FrozenClams();
    }
}