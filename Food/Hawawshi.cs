public class Hawawshi : IFood
{
    public string Name => "Hawawshi";

    public decimal Price => 95;

    public void Accept(IFoodVisitor visitor)
    {
        visitor.Visit(this);
    }
}