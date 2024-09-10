public class ConsoleUserInterface : IUserInterface
{
    public void DisplayIngredients(List<Ingredient> ingredients)
    {
        foreach (Ingredient ingredient in ingredients)
        {
            Console.WriteLine(ingredient.ToString());
        }
    }
    // Method to prompt user to select ingredients

    public void PromptUserToSelectIngredients(List<Ingredient> ingredients, Recipe newRecipe)
    {

        while (true)
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
            // Attempt to parse user input into an integer. If the input is not a valid number, exit the method.
            bool IsANumber = int.TryParse(Console.ReadLine(), out int ChossenIngredientID);
            if (!IsANumber) return;

            // Check if the entered ingredient ID is within the valid range (based on ingredient IDs).
            // If the ID is out of range, skip this iteration and prompt again.
            if (ChossenIngredientID < ingredients[0].ID || ChossenIngredientID > ingredients[^1].ID) continue;

            // Add the selected ingredient to the Ingredients list. Subtract 1 from the ID to match the list index (0-based).
            newRecipe.Ingredients.Add(ingredients[ChossenIngredientID - 1]);
        }
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void ShowRecipe(string Recipe)
    {
        Console.WriteLine(Recipe);
    }
}