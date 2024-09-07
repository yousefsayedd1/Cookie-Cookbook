public class Printing
{
    public static void DisplayIngredients(List<Ingredient> ingredients)
    {
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
        }
    }
}