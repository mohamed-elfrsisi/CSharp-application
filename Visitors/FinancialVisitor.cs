public class FinancialVisitor : IFoodVisitor
{
    public void Visit(Koshari food)
    {
        Console.WriteLine($"{food.Name}: EGP {food.Price}");
    }

    public void Visit(Hawawshi food)
    {
        Console.WriteLine($"{food.Name}: EGP {food.Price}");
    }

    public void Visit(RozBelLaban food)
    {
        Console.WriteLine($"{food.Name}: EGP {food.Price}");
    }
}