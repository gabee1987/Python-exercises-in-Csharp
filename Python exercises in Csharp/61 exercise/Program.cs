using _61_exercise.Engine;
using System;
using System.IO;

namespace _61_exercise
{
    class Program
    {
        static void Main( string[] args )
        {
            //string fileName = "TestText.txt";
            //string path = Path.Combine(Environment.CurrentDirectory, @"Resource\", fileName);

            String originalText = File.ReadAllText( @"..\..\..\Resources\TestText.txt" );
            if ( string.IsNullOrEmpty( originalText ) )
                Console.WriteLine( "File couldnt found!" );

            Console.WriteLine( "Press enter to split the  text!" );
            Console.WriteLine( string.Format(@"This is the original text: \n {0}", originalText ) );
            Console.ReadKey();

            string result = SentenceSeparator.SeparateText(originalText);
            Console.ReadKey();

        }
    }
}
