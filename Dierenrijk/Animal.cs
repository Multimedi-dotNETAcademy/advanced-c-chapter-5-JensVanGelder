namespace AdvancedC_Chapter1
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual string Move()
        { 
            return ""; 
        }

        public virtual string MakeSound()
        {
            return "";
        }

        public virtual string ShowInfo()
        { 
            return $"{Name}"; 
        }
    }
}