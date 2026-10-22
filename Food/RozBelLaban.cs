public class RozBelLaban : IFood
{
    public string Name => "Roz Bel Laban";

    public decimal Price => 45;

    public void Accept(IFoodVisitor visitor)
    {
        visitor.Visit(this);
    }
}