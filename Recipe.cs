public class Recipe
{
    public List<Ingredient> Ingredients { get;} = new List<Ingredient>();
    
    // Display the recipe ingredients
    public void DisplayRecipe()
    {
        foreach (Ingredient i in Ingredients)
        {
            Console.WriteLine($"{i.Name}. {i.InstructionOnPreparing}"); 
        }
    }
    // Add ingredient to the recipe
    public void AddIngredient(Ingredient ingredient) => Ingredients.Add(ingredient);

    // Method to prompt user to select ingredients
    public void PromptUserToSelectIngredients(List<Ingredient> ingredients)
    {
        while (true)
        {
            Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
            // Attempt to parse user input into an integer. If the input is not a valid number, exit the method.
            bool IsANumber = int.TryParse(Console.ReadLine(), out int ChossenIngredientID);
            if (!IsANumber) return ;

            // Check if the entered ingredient ID is within the valid range (based on ingredient IDs).
            // If the ID is out of range, skip this iteration and prompt again.
            if (ChossenIngredientID < ingredients[0].ID || ChossenIngredientID > ingredients[^1].ID) continue;

            // Add the selected ingredient to the Ingredients list. Subtract 1 from the ID to match the list index (0-based).
            Ingredients.Add(ingredients[ChossenIngredientID - 1]);
        }
    }
}
