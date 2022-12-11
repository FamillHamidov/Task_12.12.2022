using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARY-------------------------------- -

            Dictionary<string, string> cities = new Dictionary<string, string>();
            cities.Add("50", "Sumqayit");
            cities.Add("10", "Baki");
            cities.Add("64", "Zengilan");
            cities.Add("01", "Abseron");

            //Yeni seher elave etmek

             Console.Write("Nomreni daxil edin: ");
            string name = Console.ReadLine();
            Console.Write("Seher adini daxil edin: ");
            string surname = Console.ReadLine();
            if (name != null && surname != null)
            {
                cities.Add(name, surname);
            }
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }

            //Axtarilan seherin dictionaryde olub olmadigini yoxlamaq

            Console.Write("Axtarilan seher adini ve ya nomresini qeyd edin: ");
            string search = Console.ReadLine();
            string value = "";
            if (cities.TryGetValue(search, out value))
            {
                Console.WriteLine("Axtardiginiz seher/rayon: " + "" + value);
            }
            else
            {
                Console.WriteLine("Qeyd etdiyiniz seher/rayon movcud deyil");
            }

            //--------------------------------------------------------

            //------------------------L I S T----------------------------------

            List<string> phone = new List<string>();

            phone.Add("Iphone");
            phone.Add("Samsung");
            phone.Add("Xiaomi");

            Console.Write("Telefonun adini elave edin:");
            string phonename = Console.ReadLine();
            if (phonename != null)
            {
                phone.Add(phonename);
            }
            foreach (string item in phone)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(phone.Capacity);
            Console.WriteLine(phone.Count);

            //-------------------------------Queue < T > Class------------------------
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.Write("Ilk indexdeki elementin siradan cixarilasi: ");
            Console.WriteLine(numbers.Dequeue());
            Console.Write("Sonraki elemenet: ");
            Console.WriteLine(numbers.Peek());
            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine("-----------");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            Queue<int> numberscopy = new Queue<int>(numbers.ToArray());
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            //-------------------------SortedList------------------------ -

            SortedList<string, string> operators = new SortedList<string, string>();
            operators.Add("050", "Azercell");
            operators.Add("055", "Bakcell");

            Console.Write("Nomreni daxil edin: ");
            string nmbr = Console.ReadLine();
            Console.Write("Operator adini daxil edin: ");
            string opname = Console.ReadLine();
            try
            {
                if (nmbr != null && opname != null)
                {
                    operators.Add(nmbr, opname);
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Bu operator artiq movcuddur");
            }

            foreach (var item in operators)
            {
                Console.WriteLine(item);
            }
            string value1 = "";
            if (operators.TryGetValue(nmbr, out value1))
            {
                Console.WriteLine("Axtardiginiz operator:" + "" + value1);
            }
            else
            {
                Console.WriteLine("Bu operator movcud deyil");
            }

            //---------------Stack------------------ -

            //Stack - da sonuncu elave edilen element ekrana cixaranda 1ci olaraq ilk elave edilen ise sonuncu olaraq cixir
            Stack<char> letters = new Stack<char>();
            letters.Push('A');
            letters.Push('B');
            letters.Push('C');
            letters.Push('D');

            foreach (char item in letters)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(letters.Pop());
            Console.WriteLine(letters.Peek());
            Console.WriteLine(letters.Pop());
            Console.WriteLine("-----------------");
            foreach (char item in letters)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");

            //Copy edende tersine copy edir
            Stack<char> copyltr = new Stack<char>(letters.ToArray());
            foreach (char item in copyltr)
            {
                Console.WriteLine(item);
            }


            //-----------------Hashtable-------------------------- -

            Hashtable product = new Hashtable();
            product.Add(1000, "Telefon");
            product.Add(800, "Tv");
            product.Add(1500, "Soyuducu");

            int prdctPrice = Convert.ToInt16(Console.ReadLine());
            string prdctName = Console.ReadLine();
            if (product.ContainsKey(prdctPrice) && product.ContainsValue(prdctName))
            {
                Console.WriteLine("Artiq movcuddur");
            }
            else
            {
                product.Add(prdctPrice, prdctName);
            }
            Console.ReadKey();
        }
    }
}
