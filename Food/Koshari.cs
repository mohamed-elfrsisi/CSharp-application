public class Koshari : IFood
{
    public string Name => "Koshari";

    public decimal Price => 70;

    public void Accept(IFoodVisitor visitor)
    {
        visitor.Visit(this);
    }
}