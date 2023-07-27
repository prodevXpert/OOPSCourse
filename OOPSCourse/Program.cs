namespace OOPSCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            AccMod _obj=new AccMod();
            _obj.PrintData();
        }
    }

    class AccMod
    {
        public  void PrintData()
        {
            Console.WriteLine("I am Data here");
            Console.ReadLine();
        }
    }
}