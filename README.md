# 🍽️ Mst4faKFS — Visitor Design Pattern in C#

A simple C# console application demonstrating the **Visitor Design Pattern** through a fictional Egyptian restaurant serving Koshari, Hawawshi, and Roz Bel Laban.

## 📌 Project Overview

The restaurant has three food items, and we want to perform different operations on them without putting every operation inside the food classes.

This project demonstrates how the Visitor Pattern separates operations from the objects they operate on.

### 🍲 Food Items

- **Koshari** — EGP 70
- **Hawawshi** — EGP 95
- **Roz Bel Laban** — EGP 45

*Prices are fictional and used for demonstration purposes.*

### 👥 Visitors

| Visitor | Responsibility |
|---|---|
| `FinancialVisitor` | Displays food prices and demonstrates financial operations. |
| `NutritionVisitor` | Demonstrates ingredient and nutritional-quality reviews. |
| `CalorieVisitor` | Demonstrates calorie-calculation operations. |

> Note: Nutrition reviews and calorie calculations are illustrative demonstrations. The current implementation does not perform validated nutritional analysis or calculate actual calorie values.

## 🧠 What Is the Visitor Pattern?

The Visitor Pattern is a behavioral design pattern that lets you add operations to a group of object types without placing all those operations inside the object classes themselves.

In this project:

- `IFood` defines the food element contract.
- `IFoodVisitor` defines the operations supported for each food type.
- `Koshari`, `Hawawshi`, and `RozBelLaban` implement the food elements.
- The visitor classes implement the operations.
- `Accept()` dispatches the food object to the appropriate `Visit()` method.

### 🔄 How It Works

```csharp
public void Accept(IFoodVisitor visitor)
{
    visitor.Visit(this);
}
```

- `Accept(visitor)` receives a visitor.
- `this` refers to the current food object.
- `visitor.Visit(this)` calls the matching overload for that food type.

This is the core mechanism behind the Visitor Pattern.

## 📁 Project Structure

```text
Mst4faKFS/
├── Food/
│   ├── Koshari.cs
│   ├── Hawawshi.cs
│   └── RozBelLaban.cs
├── Interfaces/
│   ├── IFood.cs
│   └── IFoodVisitor.cs
├── Visitors/
│   ├── FinancialVisitor.cs
│   ├── NutritionVisitor.cs
│   └── CalorieVisitor.cs
├── Program.cs
├── Mst4faKFS.csproj
├── .gitignore
└── README.md
```

## ⚙️ Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) compatible with the target framework in `Mst4faKFS.csproj`
- A code editor such as Visual Studio or Visual Studio Code
- Git (optional, for version control)

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/mohamed-elfrsisi/CSharp-application.git
cd CSharp-application
```

### 2. Switch to the project branch

```bash
git switch VisitorDesignPattern
```

### 3. Run the application

Navigate to the directory containing `Mst4faKFS.csproj`, then run:

```bash
dotnet run
```

## 💻 Example Output

```text
Koshari: EGP 70
Reviewing ingredients of Koshari
Calculating calories for Koshari
---------------
Hawawshi: EGP 95
Reviewing ingredients of Hawawshi
Calculating calories for Hawawshi
---------------
Roz Bel Laban: EGP 45
Reviewing ingredients of Roz Bel Laban
Calculating calories for Roz Bel Laban
---------------
```

## ✅ Key Benefits Demonstrated

- **Separation of concerns:** Food classes represent food items; visitor classes contain additional operations.
- **Extensibility:** New operations can be implemented in new visitor classes.
- **Organization:** Related operations are grouped together.
- **Double dispatch:** The food type and visitor determine which `Visit()` implementation runs.

## ⚖️ Trade-offs

The Visitor Pattern works well when the set of food types is relatively stable and new operations are added frequently.

However, adding a new food type requires updating `IFoodVisitor` and the concrete visitors that implement it. Consider this trade-off when choosing the pattern for a real application.

## 🛠️ Technologies

- C#
- .NET
- Object-Oriented Programming (OOP)
- Visitor Design Pattern

## 👨‍💻 Author

**Mohamed El-Farsisi**

GitHub: [@mohamed-elfrsisi](https://github.com/mohamed-elfrsisi)

---

*Created as a practical learning project to understand and demonstrate the Visitor Design Pattern in C#.*
