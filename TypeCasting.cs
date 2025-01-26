namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Casting = Converting value to a different data type

            double a = 3.14;
            int b = Convert.ToInt32(a); //double to int

            int c = 123;
            double d = Convert.ToDouble(c); //int to double

            int e = 321;
            String f = Convert.ToString(d); // int to string

            String g = "$";
            char h = Convert.ToChar(g); // string to char

            String i = "true";
            bool j = Convert.ToBoolean(i); //string to bool

            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(h);
            Console.WriteLine(j);


        }
    }
}
