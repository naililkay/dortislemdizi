namespace hhh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  object[] result = GetResult(new double[] {15,5 });


         // 1. yol
            object[] result = GetResult(800, 15, 5,10,50,20,50);
           
            Console.WriteLine("Toplam " + result[0]);
            Console.WriteLine("Çıkan " + result[1]);
            Console.WriteLine("Çarpım " + result[2]);
            Console.WriteLine("Bölüm " + result[3]);

            Console.WriteLine();

            // 2.yol

            Console.WriteLine("String Olan Bölüm");

            string[] stringresult = GetResultString(800, 15, 5, 10, 50, 20, 50,100);

            foreach (var item in stringresult)
            {
                Console.WriteLine(item +" ");
            }

            
        }

        public static object[] GetResult(params double[] values) 
        {

            double topla = values[0], cikar= values[0], carp= values[0], bol = values[0];

            

            for (int i = 1;  i < values.Length; i++)
            {
                topla += values[i];
                cikar -= values[i];
                carp *= values[i];
                bol /= values[i];
            }

            return new object[] { topla, cikar, carp, bol };

        }

        public static string[] GetResultString(params double[] values)
        {

            double topla = values[0], cikar = values[0], carp = values[0], bol = values[0];



            for (int i = 1; i < values.Length; i++)
            {
                topla += values[i];
                cikar -= values[i];
                carp *= values[i];
                bol /= values[i];
            }

            return new string[] {" Toplam " +  topla, " Çıkan " +  cikar, " Çarpım " + carp , " Bölüm " +  bol };

        }

    }
}