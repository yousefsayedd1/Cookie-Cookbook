public class Recipe
{
    public List<Ingredient> Ingredients { get;} = new List<Ingredient>();
   
    public override string ToString()
    {
        string StringFormate = "";
        foreach (Ingredient i in Ingredients)
        {
            StringFormate += $"{i.Name}. {i.InstructionOnPreparing}\n";
        }
        return StringFormate;
    }
    // Add ingredient to the recipe
    public void AddIngredient(Ingredient ingredient) => Ingredients.Add(ingredient);

    
}
