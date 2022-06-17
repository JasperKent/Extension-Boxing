namespace ExtensionBoxing
{
    public struct PersonS : INameable
    {
        public string Name { get; set; }

        public override string ToString() => Name;
    }

    public class PersonC : INameable
    {
        public string Name { get; set; } = "";

        public override string ToString() => Name;
    }
}
