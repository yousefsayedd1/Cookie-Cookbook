// List of all available ingredients with IDs matching their index+1 in the list.
List<Ingredient> ingredients = new List<Ingredient>()
{
    new WheatFlour(),
    new CoconutFlour(),
    new Butter(),
    new Chocolate(),
    new Sugar(),
    new Cardamom(),
    new Cinnamon(),
    new CocoaPowder()
};
// Initialize the repository for storing recipes
RecipeRepository recipeRepository = new RecipeRepository("testfile.json");

// Retrieve all recipes from JSON file
List<Recipe> recipes = recipeRepository.ResorteALLRecipesFromJson(ingredients);
if (recipes.Count > 0)
{
    Console.WriteLine("Existing recipes are:\n");
    for (int i = 0; i <  recipes.Count; i++)
    {
        Console.WriteLine($"***** {i+1} *****");
        recipes[i].DisplayRecipe();
        Console.WriteLine();
    }
}
// Create a new cookie recipe
Console.WriteLine("Create a new cookie recipe! Available ingredients are:");
Printing.DisplayIngredients(ingredients);
Recipe NewRecipe = new Recipe();
NewRecipe.PromptUserToSelectIngredients(ingredients);
if (NewRecipe.Ingredients.Count == 0)
{
    Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
}
else
{
    Console.WriteLine("Recipe added:");
    NewRecipe.DisplayRecipe();
    // Add Recipe to JSON file
    recipeRepository.SaveRecipeToJson(NewRecipe);
}
