namespace AbstractSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new DerivedClass();

            Console.WriteLine(d.GetName());
        }
    }

    public abstract class BaseClass
    {
        public string GetName() => "Base class name";
    }

    public sealed class DerivedClass : BaseClass
    {
        public new string GetName()
        {
            return "Derived class name";
        }
    }
}

