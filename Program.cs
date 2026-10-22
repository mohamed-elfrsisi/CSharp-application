IFood[] foods =
{
    new Koshari(),
    new Hawawshi(),
    new RozBelLaban()
};

IFoodVisitor financial = new FinancialVisitor();
IFoodVisitor nutrition = new NutritionVisitor();
IFoodVisitor calories = new CalorieVisitor();

foreach (IFood food in foods)
{
    food.Accept(financial);
    food.Accept(nutrition);
    food.Accept(calories);

    Console.WriteLine("---------------");
}