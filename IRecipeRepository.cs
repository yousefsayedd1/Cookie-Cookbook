
public interface IRecipeRepository
{
    List<Recipe> Read(List<Ingredient> ingredients);
    void Save(Recipe newRecipe);
}