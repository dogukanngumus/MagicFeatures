using System.Collections;

namespace ObjectInitializer;

public class ObjectInitializerTestClass<T> : IEnumerable<T>
{
    
    public string this[int index] // Object indexer.
    {
        get => "Doğukan";
    }
    
    public string this[int index, string key] // Object indexer.
    {
        get => "Doğukan";
    }
    public void Add(int number) // Object initializer tanımlama.
    {
        Console.WriteLine($"Number: {number}");
    }

    public IEnumerator<T> GetEnumerator()
    {
        return null;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return null;
    }
}