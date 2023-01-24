namespace CheckedAndUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * C# programlama dili aritmetik işlemlerde hata almamamız için overflow durumlarında bizi korumaktadır.
             */
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            
            Console.WriteLine($"Min: {minValue}, Max: {maxValue}"); // output will be : Min: -2147483648, Max: 2147483647

            minValue--;
            maxValue++;
            
            Console.WriteLine($"Min: {minValue}, Max: {maxValue}"); // output will be : Min: 2147483647, Max: -2147483648
            
            /*
             *  Bir örnek daha verecek olursak maximum long bir değeri explicit olarak integer bir değere cast edersek
             *  normal şartlarda hata almamız gerekir ancak C# programlama dili bizi bundan koruyacaktır.
             */
            
            long myMaxLong = long.MaxValue;
            int castedLong = (int)myMaxLong;
            
            Console.WriteLine(castedLong); // output will be : -1
            
            /*
             *  Eğer bu gibi durumlarda hata almanız gerektiğini düşünüyorsanız checked ve unchecked özelliklerini
             *  kullanabilirsiniz.
             */

            unchecked
            {
                int anotherCastedLong = (int)myMaxLong; // Burada exception fırlatmayacaktır.
                Console.WriteLine(anotherCastedLong);
            }
            
            checked
            {
                int anotherCastedLong = (int)myMaxLong; // Burada exception fırlatacaktır.
                Console.WriteLine(anotherCastedLong);
            }

        }
    }
 
}
