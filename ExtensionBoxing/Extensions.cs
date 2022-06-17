namespace ExtensionBoxing
{
    public static class Extensions
    {
        public static void Ennoble<T>(this ref T nameable)
            where T : struct, INameable
        {
            nameable.Name = "Sir " + nameable.Name;
        }

        public static void Ennoble(this INameable nameable)
        {
            nameable.Name = "Sir " + nameable.Name;
        }
    }
}
