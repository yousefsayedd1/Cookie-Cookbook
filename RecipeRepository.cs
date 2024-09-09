using System.Text.Json;

public class JsonRecipeRepository : IRecipeRepository

{
    // Property that holds the file path where recipes will be saved.
    public string FilePath { get; private set; }
    // Constructor that initializes the repository with a file path.
    public JsonRecipeRepository(string path)
    {
        FilePath = path;
    }
    // Method that saves a recipe object to a JSON file.
    // The method converts the Recipe's ingredients into a list of integers (IDs),
    // stores it in a collection of recipes, and writes the result to a JSON file.
    public void Save(Recipe Recipe1)
    {
        // List to store the ingredient IDs of the recipe.
        List<int> ingredients = new List<int>();

        // Loop through each ingredient in the recipe and store its ID in the list.
        foreach (Ingredient ingredient in Recipe1.Ingredients)
        {
            ingredients.Add(ingredient.ID);
        }
        // Retrieve the current recipes stored in the JSON file.
        List<List<int>> RecipesIngredients = RestoreJsonFileContent();
        RecipesIngredients.Add(ingredients);
        // Serialize the updated list of recipes to a JSON string.
        string JsonString = JsonSerializer.Serialize(RecipesIngredients);
        // Write the JSON string to the specified file.
        File.WriteAllText(FilePath, JsonString);
    }
    // Restore all recipes from JSON, matching IDs to ingredient objects
    public List<Recipe> Read(List<Ingredient> ingredients)
    {
        List<List<int>> RecipesIngredients = RestoreJsonFileContent();
        List<Recipe> Recipes = new List<Recipe>();
        foreach (List<int> RecipeIngredients in RecipesIngredients)
        {
            Recipe recipe = new Recipe();
            foreach(int i in RecipeIngredients)
            {
                recipe.Ingredients.Add(ingredients[i - 1]);
            }
            Recipes.Add(recipe);
        }
        return Recipes;
    }

    // Read and deserialize the JSON file content
    public List<List<int>> RestoreJsonFileContent()
    {
        List<List<int>> RecipesIngredients = new List<List<int>>();
        string JsonFileContent = File.ReadAllText(FilePath);
        if (JsonFileContent != "") RecipesIngredients = JsonSerializer.Deserialize<List<List<int>>>(JsonFileContent);
        return RecipesIngredients;
    }
}