namespace ADFGVX
{
    internal class Program
    {
        static string Kulcs;
        static string Uzenet;
        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();
            //Feladat5();
        }

        private static void Feladat3()
        {
            Console.WriteLine("3. Feladat: ");
            ADFGVXrejtjel TEST = new ADFGVXrejtjel(@"..\..\..\kodtabla\kodtabla.txt", Uzenet, Kulcs);


            Console.WriteLine($"Átalakított üzenet EX: {TEST.Uzenet}");            //.AtalakitottUzenet(Uzenet)
            Console.WriteLine(TEST.AtalakitottUzenet(Uzenet));          //NEM MŰKÖDIK

        }

        private static void Feladat5()
        {
            Console.Write("5. Feladat:");
        }

        private static void Feladat2()
        {
            Console.Write("2. Feladat:\n\tKérem a kulcsot [HOLD]: ");
            Kulcs = Console.ReadLine().ToUpper();
            Console.Write("\tKérem az üzenetet [Szeretem a csokit]: ");
            Uzenet = Console.ReadLine().ToLower();
            if (Uzenet=="")
            {
                Uzenet = "szeretem a csokit";
            }
            if (Kulcs=="")
            {
                Kulcs = "HOLD";
            }            
        }
    }
}