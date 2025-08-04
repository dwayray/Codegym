public class Chicken : Animal, IEdible
{
    public override string MakeSound()
    {
        return "Chicken: cluck cluck";
    }

    public string HowToEat()
    {
        return "Chicken: fry it";
    }
}
