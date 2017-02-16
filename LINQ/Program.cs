using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Task60();
            Console.Read();
        }

        public static void Task1()
        {
            int[] chis = { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < chis.Length; i++)
            {
                Console.Write(chis[i] + " ");
            }

            int positive = chis.First(x => x > 0);
            int negative = chis.Last(x => x < 0);

            Console.WriteLine(" ");
            Console.WriteLine("Первое положительное " + positive);
            Console.WriteLine("Последний отрицательный " + negative);

        }

        public static void Task2()
        {
            int[] chis = { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < chis.Length; i++)
            {
                Console.Write(chis[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Введите D ");

            int d = int.Parse(Console.ReadLine());
            int[] positive = chis.Where(x => x > 0).ToArray();
            int res = 0;

            for (int i = 0; i < positive.Length - 1; i++)
            {
                if (positive[i + 1] == d)
                {
                    res = positive[i];
                    break;
                }
            }

            if (res == 0)
                Console.WriteLine("Требуемых элементов в последовательности A нет");
            else
                Console.WriteLine("Первый положительный элемент последовательности A, оканчивающийся цифрой D = " + res);

        }

        public static void Task3()
        {
            string[] pos = { "Test", "2_Victory", "Random", "1Numbers", "ToTest", "123Spart", "First" };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите L ");

            int l = int.Parse(Console.ReadLine());
            int t;
            string current = "";

            current = pos.LastOrDefault(x => int.TryParse(x[0].ToString(), out t) && x.Length == l);

            if (current == null)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("Последняя строка из A, начинающаяся с цифры и имеющую длину L = " + current);

        }

        public static void Task4()
        {
            string[] pos = { "Test", "2_Victory", "Random", "1Numbers", "ToTest", "123Spart", "First" };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите C ");
            char c = Console.ReadLine()[0];

            string cur = null;

            try
            {
                cur = pos.Single(x => x[x.Length - 1] == c);

            }
            catch
            {
                Console.WriteLine("Error");

            }

            Console.WriteLine(cur);
        }

        public static void Task5()
        {
            string[] pos = { "Test", "2_Victory2", "Random", "1Numbers1", "ToTest", "123Spart", "1First1", "TTT", "1Fid1", "3HHH3" };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите C ");
            char c = Console.ReadLine()[0];

            string[] mas = pos.Where(x => x[0] == c && x[x.Length - 1] == c).ToArray();
            Console.WriteLine("Кол элементов = " + mas.Length);

        }

        public static void Task6()
        {
            string[] pos = { "Test", "2_Victory2", "Random", "1Numbers1", "ToTest", "123Spart", "1First1", "TTT", "1Fid1", "3HHH3" };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Cумма " + pos.Sum(x => x.Length));

        }

        public static void Task7()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 21);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");

            int[] negative = pos.Where(x => x < 0).ToArray();

            Console.WriteLine("Кол отрицательных элементов = " + negative.Length + " Сума = " + negative.Sum());
        }

        public static void Task8()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 9);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");

            int[] positive = pos.Where(x => x > 0 && x > 10 && x < 100).ToArray();

            Console.WriteLine(positive.Length > 0 ? "Кол положительных двухзначных элементов = " + positive.Length + " Среднее арифм = " + pos.Average() : "0 0");

        }

        public static void Task9()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");

            try
            {
                Console.WriteLine("Мин положительный элемент " + pos.Where(x => x > 0).Min());
            }
            catch
            {
                Console.WriteLine("0");
            }

        }

        public static void Task10()
        {

            char[] arr = Enumerable.Range(0, 32).Select((x, i) => (char)('А' + i)).ToArray();

            foreach (char i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите L ");
            int len = int.Parse(Console.ReadLine());

            try
            {
                char max = arr.Where(x => (int)x == len).Max();
                Console.WriteLine("Результат = " + max);
            }
            catch
            {
                Console.WriteLine("Пустая строка");
            }
        }

        public static void Task11()
        {
            string[] pos = { "Test", "2_Victory2", "Random", "1Numbers1", "ToTest", "123Spart", "1First1", "TTT", "1Fid1", "3HHH3" };

            Console.WriteLine("Последовательность ");

            for (int i = 0; i < pos.Length; i++)
            {
                Console.Write(pos[i] + " ");
            }

            Console.WriteLine(" ");

            string result = pos.Aggregate((a, b) => a[0].ToString() + " " + b[0].ToString());

            Console.WriteLine("Результат = " + result);
        }

        public static void Task12()
        {
            IEnumerable<int> pos = Enumerable.Range(1, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");

            float result = pos.Aggregate((a, b) => (a % 10) * (b % 10));

            Console.WriteLine("Результат " + result);

        }

        public static void Task13()
        {
            Console.WriteLine("Введите N ");
            int n = int.Parse(Console.ReadLine());

            float res = Enumerable.Range(1, n).Sum(x => 1 + (1 / x));

            Console.WriteLine("Результат = " + res);
        }

        public static void Task14()
        {
            Console.WriteLine("Введите A ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите B ");
            int b = int.Parse(Console.ReadLine());

            double res = Enumerable.Range(a, b).Average(x => (a * a + Math.Pow((a + 1), 2) + x + b * b) / (b - a + 1));

            Console.WriteLine("Результат = " + res);

        }

        public static void Task15()
        {
            Console.WriteLine("Введите N ");
            int n = int.Parse(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("N меньше 1, ошибка ");
                return;
            }

            double res = Enumerable.Range(1, n).Aggregate((a, b) => a * b);

            Console.WriteLine("Результат = " + res);

        }

       //------------------------------------------------------------

        public static void Task16()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 20);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine("Результат ");

            pos = pos.Where(x => x > 0);

            Console.WriteLine(" ");

            foreach (int i in pos)
                Console.Write(i + " ");

        }

        public static void Task17()
        {
            Random rnd = new Random();
            int[] num = new int[50];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(1, 20);
                Console.Write(num[i] + " ");
            }

            int[] res = num.Where(x => (x % 2) == 0 ).Distinct().ToArray();

            Console.WriteLine(" ");
            Console.WriteLine("Результат ");

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }

        }

        public static void Task18()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 20);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine("Результат ");

            pos = pos.Where(x => x < 0 && x % 2 == 0).Reverse();

            Console.WriteLine(" ");

            foreach (int i in pos)
                Console.Write(i + " ");
        }

        public static void Task19()
        {
            IEnumerable<int> pos = Enumerable.Range(-20, 100);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine("Введите D ");
            int d = int.Parse(Console.ReadLine());


            Console.WriteLine("Результат ");


            pos = pos.Where(x => x > 0 && x % 10 == d).Distinct();

            Console.WriteLine(" ");

            foreach (int i in pos)
                Console.Write(i + " ");
        }

        public static void Task20()
        {
            IEnumerable<int> pos = Enumerable.Range(-20, 100);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Результат ");


            pos = pos.Where(x => (x > 10 && x < 100) || (x < -10 && x > -100)).OrderBy(x => x); 

            Console.WriteLine(" ");

            foreach (int i in pos)
                Console.Write(i + " ");
        }

        public static void Task21()
        {
            Random rnd = new Random();
            string[] pos = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString()).ToArray();

            Console.WriteLine("Pos");
            foreach (var i in pos)
                Console.Write(i + " ");

            var res = pos.OrderBy(x => x.Length).ThenByDescending(x => x);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task22()
        {
            Random rnd = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1,1000).ToString()).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите K ");
            int k = int.Parse(Console.ReadLine());
            int t;

            string[] res = arr.Where(x => x.Length == k && int.TryParse(x[x.Length - 1].ToString(), out t)).OrderBy(x => x).ToArray();

            Console.WriteLine(" ");
            Console.WriteLine("Результат ");

            foreach (string i in res)
            {
                Console.Write(i + " ");
            }

        }

        public static void Task23()
        {
            IEnumerable<int> pos = Enumerable.Range(-20, 100);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Введите K ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Результат ");


            pos = pos.Skip(k).Where(x => (x % 2 == 1 && (x > 10 && x < 100)) || (x % 2 == -1 && (x < -10 && x > -100)) ).OrderByDescending(x => x);

            Console.WriteLine(" ");

            foreach (int i in pos)
                Console.Write(i + " ");
        }

        public static void Task24()
        {
            Random rnd = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString()).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите K ");
            int k = int.Parse(Console.ReadLine());
            // int t;

            string[] res = arr.Skip(k).Where(x => (x.Length % 2 == 1) && Char.IsUpper(x[0])).Reverse().ToArray();

            Console.WriteLine(" ");
            Console.WriteLine("Результат ");

            foreach (string i in res)
            {
                Console.Write(i + " ");
            }

        }

        public static void Task25()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Введите K1 ");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите K2 ");
            int k2 = int.Parse(Console.ReadLine());

            //   float res = pos.Skip(k1).Take(k2).Where(x => x > 0).Sum();

            pos = pos
                .Skip(k1)
                .Take(k2 - k1)
                .Where(x => x > 0);

            Console.WriteLine(" ");
            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Результат " + pos.Sum());

        }

        public static void Task26()
        {
            Console.WriteLine("N ");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            string[] arr = Enumerable.Range(65, n).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString()).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите K1 ");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите K2 ");
            int k2 = int.Parse(Console.ReadLine());

            string[] first = arr.Take(k1).ToArray();
            string[] second = arr.Skip(k2).ToArray();

            //string[] res = first.Union(second).ToArray();
            double res = first.Union(second).Average(x => x.Length);

            Console.WriteLine("Результат " + res);
        }

        public static void Task27()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Введите D ");
            int d = int.Parse(Console.ReadLine());

            pos = pos.SkipWhile(x => x < d).Where(x => x % 2 == 1).Reverse();

            Console.WriteLine(" ");
            Console.WriteLine("Результат ");

            foreach (int i in pos)
                Console.Write(i + " ");
        }

        public static void Task28()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : ' ') ).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите l ");
            int l = int.Parse(Console.ReadLine());

            string[] res1 = arr
                .SkipWhile(x => x.Length < l)
                .Where(x => Char.IsLetter(x[x.Length - 1]))
                .OrderByDescending(x => x.Length).ToArray();

            // string[] res2 = arr.GroupBy(x => x.Length).Where(n => n.Count() < 1).ToArray();
            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (string i in res1)
            {
                Console.Write(i + " ");
            }

        }

        public static void Task29()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Введите D ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Введите K ");
            int k = int.Parse(Console.ReadLine());

            IEnumerable<int> a = pos.TakeWhile(x => x < d);
            IEnumerable<int> b = pos.Skip(k);

            IEnumerable<int> res = a.Union(b).OrderByDescending(x => x);


            Console.WriteLine("Результат");
            foreach (int i in res)
                Console.Write(i + " ");




        }

        public static void Task30()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Введите K ");
            int k = int.Parse(Console.ReadLine());

            IEnumerable<int> a = pos.Where(x => x % 2 == 0);
            IEnumerable<int> b = pos.Skip(k);
            IEnumerable<int> res = a.Except(b).Reverse();

            Console.WriteLine("Результат");
            foreach (int i in res)
               Console.Write(i + " ");

        }

        public static void Task31()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : ' ')).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите l ");
            int l = int.Parse(Console.ReadLine());

            var a = arr.Take(l);
            var b = arr.Reverse().TakeWhile(x => !Char.IsDigit(x[x.Length - 1]));
            var res1 = a.Intersect(b).OrderBy(x => x.Length);
            var res2 = res1.OrderBy(x => x);

            Console.WriteLine("Результат 1");
            foreach (string i in res1)
                Console.Write(i + " ");

            Console.WriteLine(" ");
            Console.WriteLine("Результат 2");
            foreach (string i in res2)
                Console.Write(i + " ");
        }

        //------------------------------------------------------------------

        public static void Task32()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : ' ')).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            char[] res = arr.Select(x => x[0]).Reverse().ToArray();

            Console.WriteLine(" ");
            Console.WriteLine("Результат");
            foreach (char i in res)
                Console.Write(i + " ");
        }

        public static void Task33()
        {
            IEnumerable<int> pos = Enumerable.Range(-10, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            var res = pos
                .Where(x => x > 0)
                .Select(x => x % 10)
                .Distinct();

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (int i in res)
                Console.Write(i + " ");
        }

        public static void Task34()
        {
            IEnumerable<int> pos = Enumerable.Range(1, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            var res = pos
                .Where(x => x % 2 == 1)
                .Select(x => x.ToString())
                .OrderBy(x => x);

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (string i in res)
                Console.Write(i + " ");
        }

        public static void Task35()
        {
            IEnumerable<int> pos = Enumerable.Range(1, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            var res = pos
                .Select((x, i) => x * i)
                .Where(x => x > 10 && x < 100)
                .Reverse();

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (int i in res)
                Console.Write(i + " ");
        }

        public static void Task36()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : ' ')).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            var res = arr
                .Select(x => x.Length % 2 == 0 ? x[x.Length - 1] : x[0])
                .OrderByDescending(x => x);

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (char i in res)
                Console.Write(i + " ");
        }

        public static void Task37()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => rnd1.Next(0, 2) == 1 ? ((char)('A' + i)).ToString() : "").ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            var res = arr
                .Select((x, i) => x != "" ? x + i : "")
                .Where(x => x != "")
                .OrderBy(x => x);

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (string i in res)
                Console.Write(i + " ");
        }

        public static void Task38()
        {
            IEnumerable<int> pos = Enumerable.Range(1, 50);

            foreach (int i in pos)
                Console.Write(i + " ");

            var res = pos
                .Select((item, index) => new { Item = item, Index = index })
                .Where(x => x.Index % 3 != 0)
                .Select(x => x.Index % 3 == 1 ? x.Item * 2 : x.Item);

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (int i in res)
                Console.Write(i + " ");
        }

        public static void Task39()
        {
           Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : ' ')).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            var res = arr.SelectMany(n => n.Where(x => Char.IsDigit(x)));
                

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (char i in res)
                Console.Write(i + " ");
        }

        public static void Task40()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] arr = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : ' ')).ToArray();

            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите k ");
            int k = int.Parse(Console.ReadLine());

            var res = arr.Where(x => x.Length >= k).SelectMany(x => x).Reverse();

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (char i in res)
                Console.Write(i + " ");
        }

        public static void Task41()
        {
            string[] cars = { "Nissan.Aston Martin", "Chevrolet.Alfa Romeo", "Chrysler.Dodge.BMW",
                            "Ferrari.Audi.Bentley", "Ford.Lexus", "Mercedes.Toyota", "Volvo.Subaru" };

            foreach (string i in cars)
            {
                Console.Write(i + "   ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите k ");
            int k = int.Parse(Console.ReadLine());

            var res = cars.SelectMany(x => x.Split('.')).Where(x => x.Length == k);

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (string i in res)
                Console.Write(i + " ");

        }

        public static void Task42()
        {
            string[] cars = { "Nissan.Aston Martin", "Chevrolet.Alfa Romeo", "Chrysler.Dodge.BMW",
                            "Ferrari.Audi.Bentley", "Ford.Lexus", "Mercedes.Toyota", "Volvo.Subaru" };

            foreach (string i in cars)
            {
                Console.Write(i + "   ");
            }

            var res = cars
                .SelectMany((x,i) => i % 2 == 1 ? x.Where(n => char.IsUpper(n)) : x.Where(n => char.IsLower(n)));
               
            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (char i in res)
                Console.Write(i + " ");
        }

        public static void Task43()
        {
            string[] cars = { "Nissan.Aston Martin", "Chevrolet.Alfa Romeo", "Chrysler.Dodge.BMW",
                            "Ferrari.Audi.Bentley", "Ford.Lexus", "Mercedes.Toyota", "Volvo.Subaru" };

            foreach (string i in cars)
            {
                Console.Write(i + "   ");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Введите k ");
            int k = int.Parse(Console.ReadLine());

            var res = cars.SelectMany((x, i) => x.Where((n, m) => m % 2 == (i < k ? 1 : 0)) );

            Console.WriteLine(" ");
            Console.WriteLine("Результат");

            foreach (var i in res)
                Console.Write(i + " ");
        }

        //-------------------------------------------------------------

        public static void Task44()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 50);
            IEnumerable<int> posB = Enumerable.Range(-10, 50);

            Console.WriteLine("A");

            foreach (int i in posA)
                Console.Write(i + " ");

            Console.WriteLine("\nB");

            foreach (int i in posB)
                Console.Write(i + " ");

            Console.WriteLine("\nВведите k1 ");
            int k1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k2 ");
            int k2 = int.Parse(Console.ReadLine());

            var res = posA
                .Where(x => x > k1)
                .Concat(posB.Where(x => x < k2))
                .OrderBy(x => x);

            Console.WriteLine("\nРезультат");

            foreach (var i in res)
                Console.Write(i + " ");

        }

        public static void Task45()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] posA = Enumerable.Range(65, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() ).ToArray();
            string[] posB = Enumerable.Range(23, 26).Select((x, i) => (char)('A' + i) + rnd.Next(1, 400).ToString() ).ToArray();

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            Console.WriteLine("\nВведите k1 ");
            int l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите k2 ");
            int l2 = int.Parse(Console.ReadLine());

            var res = posA
                .Where(x => x.Length == l1)
                .Concat(posB.Where(x => x.Length == l2))
                .OrderByDescending(x => x);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task46()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 20);
            IEnumerable<int> posB = Enumerable.Range(50, 20);

            Console.WriteLine("A");
            foreach (int i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (int i in posB)
                Console.Write(i + " ");

            var res = posA
                .Join(
                posB,
                a => a % 10,
                b => b % 10,
                (a, b) => 
                {
                    return a + "-" + b;
                });

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");

        }

        public static void Task47()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 20);
            IEnumerable<int> posB = Enumerable.Range(50, 20);

            Console.WriteLine("A");
            foreach (int i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (int i in posB)
                Console.Write(i + " ");

            var res = posA
                .Join(
                posB,
                a => a % 10,
                b => int.Parse(b.ToString()[0].ToString()),
                (a, b) => new
                {
                    // return a + ":" + b;
                    el1 = a,
                    el2 = b,
                    r = a + ":" + b
                }).OrderBy(x => x.el1).ThenBy(x => x.el2);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i.r + " ");
        }

        public static void Task48()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] posA = Enumerable.Range(65, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString()).ToArray();
            string[] posB = Enumerable.Range(23, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 400).ToString()).ToArray();

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var res = posA
                .Join(
                posB,
                a => a.Length,
                b => b.Length,
                (a, b) => new
                {
                    // return a + ":" + b;
                    el1 = a,
                    el2 = b,
                    r = a[0] + ":" + b[0]
                }).OrderBy(x => x.el1).ThenByDescending(x => x.el2);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i.r + " ");
        }

        public static void Task49()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] posA = Enumerable.Range(65, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString()).ToArray();
            string[] posB = Enumerable.Range(23, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 400).ToString()).ToArray();
            string[] posC = Enumerable.Range(13, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 700).ToString()).ToArray();

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");
            Console.WriteLine("\nC");
            foreach (var i in posC)
                Console.Write(i + " ");

            var res = posA
                .Join(posB.Join(posC,
                          a => a[0],
                          v => v[0],
                          (b, c) => new
                          {
                              b,
                              c
                          }),
                x => x[0],
                y => y.b[0],
                (a, y) => new
                {
                    a,
                    y.b,
                    y.c
                })
                .GroupBy(x => x.a)
                .SelectMany(x => x
                                .OrderBy(y => y.b)
                                .ThenByDescending(y => y.c))
                .Select(x => x.a + "=" + x.b + "=" + x.c);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task50()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] posA = Enumerable.Range(65, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString()).ToArray();
            string[] posB = Enumerable.Range(23, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 400).ToString()).ToArray();

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var res = posA
                .GroupJoin(posB,
                a => a[0],
                b => b[0],
                (m, os) => new
                {
                    r = m + ":" + os.Count()
                }
                );

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i.r + " ");

        }

        public static void Task51()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 20);
            IEnumerable<int> posB = Enumerable.Range(50, 20);

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var res = posA
                .GroupJoin(posB,
                a => a % 10,
                b => b % 10,
                (m, os) => new
                {
                    a = m,
                    sum = os.Sum(),
                    r = os.Sum() + ":" + m 
                }
                )
                .OrderBy(x => x.sum)
                .ThenByDescending(x => x.a);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i.r + " ");

        }

        public static void Task52()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] posA = Enumerable.Range(65, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : rnd.Next(1, 1000).ToString()[0])).ToArray();
            string[] posB = Enumerable.Range(23, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 400).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : rnd.Next(1, 1000).ToString()[0])).ToArray();

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var a = posA.Where(x => char.IsDigit(x[x.Length - 1])).OrderBy(x => x);
            var b = posB.Where(x => char.IsDigit(x[x.Length - 1])).OrderByDescending(x => x);

            var res = a.SelectMany(x1 => b.Select(x2 => x1 + "=" + x2));

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");

        }

        public static void Task53()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 20);
            IEnumerable<int> posB = Enumerable.Range(1, 20);

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var res = posA.SelectMany(x1 => posB.Select(x2 => x1 + x2)).OrderBy(x => x);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task54()
        {
            Random rnd = new Random();
            Random rnd1 = new Random();
            string[] posA = Enumerable.Range(65, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 1000).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : rnd.Next(1, 1000).ToString()[0])).ToArray();
            string[] posB = Enumerable.Range(23, 10).Select((x, i) => (char)('A' + i) + rnd.Next(1, 400).ToString() + (rnd1.Next(0, 2) == 1 ? (char)('A' + i) : rnd.Next(1, 1000).ToString()[0])).ToArray();

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var res = posA
                .GroupJoin(posB,
                a => a[0],
                b => b[0],
                (a1, b1) => b1.DefaultIfEmpty(" ").Select(x => a1 + "." + x))
                .SelectMany(x => x)
                .OrderBy(x => x);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task55()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 20);
            IEnumerable<int> posB = Enumerable.Range(1, 20);

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");
            Console.WriteLine("\nB");
            foreach (var i in posB)
                Console.Write(i + " ");

            var res = posA
                .GroupJoin(posB,
                a => a % 10,
                b => b % 10,
                (a1, b1) => b1.DefaultIfEmpty(0).Select(x => a1 + "." + x))
                .SelectMany(x => x)
                .OrderByDescending(x => x)
                .ThenBy(x => posB);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");

        }

        public static void Task56()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 100);

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");

            var res = posA
                .GroupBy(x => x % 10)
                .OrderBy(x => x.Key)
                .Select(x => x.Key + ":" + posA.DefaultIfEmpty(0).Where(y => y % 10 == x.Key).Sum() + "  ")
                .SelectMany(x => x);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task57()
        {
            IEnumerable<int> posA = Enumerable.Range(1, 100);

            Console.WriteLine("A");
            foreach (var i in posA)
                Console.Write(i + " ");

            var res = posA
                .GroupBy(x => x % 10)
                .Select(x => x.Max())
                .OrderBy(x => x % 10);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task58()
        {
            string[] pos = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "NЖигули :)"};

            Console.WriteLine("A");
            foreach (var i in pos)
                Console.Write(i + " ");

            var res = pos
                .GroupBy(x => x[0])
                .Select(x => x.OrderByDescending(y => y.Length).First())
                .OrderBy(x => x[0]);
               
            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");

        }

        public static void Task59()
        {
            string[] pos = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "NЖигули :)"};

            Console.WriteLine("A");
            foreach (var i in pos)
                Console.Write(i + " ");

            var res = pos
                .GroupBy(x => x[0])
                .Select(x => x.OrderBy(y => y.Length).First())
                .OrderByDescending(x => x.Length);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }

        public static void Task60()
        {
            string[] pos = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "NЖигули :)"};

            Console.WriteLine("A");
            foreach (var i in pos)
                Console.Write(i + " ");

            var res = pos
                .GroupBy(x => x[0])
                .Select(x => x.Sum(y => y.Length) + ":" + x.First()[0])
                .OrderByDescending(e => e.Split(':')[0])
                .ThenBy(e => e.Split(':')[1]);

            Console.WriteLine("\nРезультат");
            foreach (var i in res)
                Console.Write(i + " ");
        }


    }
}
