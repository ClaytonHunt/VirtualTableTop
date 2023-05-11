namespace VirtualTableTop.Shared
{
    public class Character
    {
        private Dictionary<Type, IComponent> components = new();

        public Character()
        {
            AddComponent(new BiographicInfo());
            AddComponent(new Attributes());
            AddComponent(new Skills());
            // Add other components as needed...
        }

        public void AddComponent<T>(T component) where T : IComponent
        {
            components[typeof(T)] = component;
        }

        public T GetComponent<T>() where T : IComponent
        {
            if (components.TryGetValue(typeof(T), out var component))
            {
                return (T)component;
            }

            return default;
        }
    }
}