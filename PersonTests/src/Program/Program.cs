using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8");
            Person jane = new Person("Jane Doe", "6.000.000-8");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
