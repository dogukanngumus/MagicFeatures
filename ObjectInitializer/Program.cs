namespace ObjectInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Bir objeyi ilk defa oluştururken default değer atamak için object initializerlar kullanılır.
             */
            List<int> numbers = new List<int>()
            {
                {1},
                {2},
                {3}
            };
            
            numbers.Add(4);
            
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            
            // Örnek:
            ObjectInitializerTestClass<int> objectInitializerTestClass = new ObjectInitializerTestClass<int>()
            {
                1,
                2,
                3
            };
            
            /*
             * Birde Object Indexer adında bir başka kavramımız var. Bir obje içerisindeki değerleri indexlemek için kullanırız.
             */
            Console.WriteLine(objectInitializerTestClass[0]);
            Console.WriteLine(objectInitializerTestClass[0, "name"]);
        }
       
    }
}
