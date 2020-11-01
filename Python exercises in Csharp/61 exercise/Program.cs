using _61_exercise.Engine;
using System;
using System.IO;

namespace _61_exercise
{
    class Program
    {
        static void Main( string[] args )
        {
            String originalText = File.ReadAllText( @"..\..\Resources\TestText.txt" );
            if ( string.IsNullOrEmpty( originalText ) )
                Console.WriteLine( "File couldnt found!" );

            Console.WriteLine( "Press enter to split the  text!" );
            Console.WriteLine( string.Format("This is the original text: {0}", originalText ) );
            Console.ReadKey();

            string result = SentenceSeparator.SeparateText(originalText);
        }
    }
}
