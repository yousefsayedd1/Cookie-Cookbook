public class Butter : Ingredient
{
    public override int ID { get; } = 3;
    public override string Name { get; } = "Butter";
    public override string InstructionOnPreparing  => $"Melt on low heat. {base.InstructionOnPreparing}";
}


