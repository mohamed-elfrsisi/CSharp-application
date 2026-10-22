public interface IFood
{
    string Name { get; }

    void Accept(IFoodVisitor visitor);
}