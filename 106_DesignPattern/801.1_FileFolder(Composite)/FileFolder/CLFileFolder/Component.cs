namespace CLFileFolder
{
    public abstract class Component
    {
        protected string name;

        public string Name { get { return name; } } 
        public Component (string name)
        {
            this.name = name;
        }
        public abstract int Size();
    }
}