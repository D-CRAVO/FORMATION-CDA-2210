namespace CLFolderFileFolder
{
    public abstract class Component
    {
        private string name;

        public string Name { get { return name; } }

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display();

    }
}