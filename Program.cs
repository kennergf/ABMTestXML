using System;

namespace ABMTestXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the RefCode");
            var refCode = Console.ReadLine().ToUpper();

            var readXML = new ReadXML(System.IO.Path.GetFullPath("InputDocument.xml"));

            if(readXML.Read())
            {
                var refText = readXML.GetReference(refCode);
                if(string.IsNullOrEmpty(refText))
                {
                    Console.WriteLine("RefCode not found");
                }
                else
                {
                    Console.WriteLine("The RefText is : " + refText);   
                }
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
