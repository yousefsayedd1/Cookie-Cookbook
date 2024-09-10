public abstract class Ingredient {
    public abstract int ID { get; }
    public abstract string Name { get; }
    public virtual string InstructionOnPreparing => "Add to other ingredients.";


}


