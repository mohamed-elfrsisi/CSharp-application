public class CalorieVisitor : IFoodVisitor
{
    public void Visit(Koshari food)
    {
        Console.WriteLine($"Calculating calories for {food.Name}");
    }

    public void Visit(Hawawshi food)
    {
        Console.WriteLine($"Calculating calories for {food.Name}");
    }

    public void Visit(RozBelLaban food)
    {
        Console.WriteLine($"Calculating calories for {food.Name}");
    }
}