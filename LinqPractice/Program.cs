using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Rastgele sayı oluşturdum
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int rndNum = rnd.Next(-22, 22);
                numbers.Add(rndNum);

            }
            Console.Write("Oluşturulan rastgele sayılar : ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            // -------------------------------------

            var evenList = numbers.Where(x => x % 2 == 0); // Elemanları filtrelemek için 


            Console.Write("\n\nÇift olan sayılar : ");

            if (evenList.Any())
            {
                foreach (int x in evenList)
                {
                    Console.Write(x + " ");
                }
            }
            else
            {
                Console.WriteLine("Sayı bulunamadı");
            }

            // -------------------------------------

            Console.Write("\n\nTek olan sayılar : ");

            var oddList = numbers.Where(x => x % 2 == 1 || x % 2 == -1); // Elemanları filtrelemek için 
            if (oddList.Any())
            {
                foreach (int x in oddList)
                {
                    Console.Write(x + " ");
                }
            }
            else
            {
                Console.WriteLine("Sayı bulunamadı");
            }

            // -------------------------------------

            Console.Write("\n\nNegatif olan sayılar : ");

            var negativeList = from number in numbers // Elemanları filtrelemek için 
                               where number < 0
                               select number;
                
            if (negativeList.Any())
            {
                foreach (int x in negativeList)
                {
                    Console.Write(x + " ");
                }
            }
            else
            {
                Console.WriteLine("Sayı bulunamadı");
            }

            // -------------------------------------

            Console.Write("\n\nPozitif olan sayılar : ");

            var positiveList = numbers.Where(x => x > 0); // Elemanları filtrelemek için 

            if (positiveList.Any())
            {
                foreach (int x in positiveList)
                {
                    Console.Write(x + " ");
                }
            }
            else
            {
                Console.WriteLine("Sayı bulunamadı");
            }

            // -------------------------------------

            Console.Write("\n\n15'ten büyük ve 22'den küçük olan sayılar : ");

            var numList = numbers.Where(x => x > 15 && x < 22); // Elemanları filtrelemek için 

            if (numList.Any())
            {
                foreach (int x in numList)
                {
                    Console.Write(x + " ");
                }
            }
            else
            {
                Console.WriteLine("Sayı bulunamadı");
            }

            // -------------------------------------

            Console.Write("\n\nRastgele oluşturulan sayıların karesi : ");

            List<int> squareList = numbers.Select(x => x).ToList(); // squareList tanımladım ve numbers listesindeki tüm elemanları select ile aktardım.
            var squareNumbers = squareList.Select(x => x * x); // Elemanları seçmek için

            foreach (int x in squareNumbers)
            {
                Console.Write(x + " ");
            }


            Console.ReadLine();
        }
    }
}
