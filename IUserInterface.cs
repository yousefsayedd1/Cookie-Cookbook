public interface IUserInterface
{
    void DisplayIngredients(List<Ingredient> ingredients);
    void PromptUserToSelectIngredients(List<Ingredient> ingredients, Recipe newRecipe);
    void ShowMessage(string message);
    void ShowRecipe(string Recipe);
}
