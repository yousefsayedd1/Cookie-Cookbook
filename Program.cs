CookieCookbook App = new CookieCookbook(new ConsoleUserInterface(),new JsonRecipeRepository("testfile.json"));
App.Run();
public class CookieCookbook
{
    private IUserInterface _userInterface;
    private IRecipeRepository _recipeRepository;
    public CookieCookbook(IUserInterface userInterface,IRecipeRepository recipeRepository) {
        _userInterface = userInterface;
        _recipeRepository = recipeRepository;
    }
    public void Run()
    {
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

        // Retrieve all recipes from JSON file
        List<Recipe> recipes = _recipeRepository.Read(ingredients);
        if (recipes.Count > 0)
        {
            _userInterface.ShowMessage("Existing recipes are:\n");
            for (int i = 0; i < recipes.Count; i++)
            {
                _userInterface.ShowMessage($"***** {i + 1} *****");
                _userInterface.ShowRecipe(recipes[i].ToString());
            }
        }
        // Create a new cookie recipe
        _userInterface.ShowMessage("Create a new cookie recipe! Available ingredients are:");
        _userInterface.DisplayIngredients(ingredients);
        Recipe NewRecipe = new Recipe();
        _userInterface.PromptUserToSelectIngredients(ingredients, NewRecipe);
        if (NewRecipe.Ingredients.Count == 0)
        {
            _userInterface.ShowMessage("No ingredients have been selected. Recipe will not be saved.");
        }
        else
        {
            _userInterface.ShowMessage("Recipe added:");
            _userInterface.ShowRecipe(NewRecipe.ToString());
            // Add Recipe to JSON file
            _recipeRepository.Save(NewRecipe);
        }

    }
}
