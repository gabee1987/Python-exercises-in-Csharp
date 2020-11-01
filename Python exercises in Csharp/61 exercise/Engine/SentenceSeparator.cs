using System;
using System.Collections.Generic;
using System.Text;

namespace _61_exercise.Engine
{
    public class SentenceSeparator
    {
        public static string SeparateText( string baseText )
        {
            string result = string.Empty;
            string[] signs = new string[2]{"?", "!" };
            var words = baseText.Split(' ');
            //Console.WriteLine( words );

            StringBuilder stb = new StringBuilder();

            for ( int i = 0; i < words.Length; i++ )
            {
                stb.Append( words[i] );
                if ( words[i].Contains( signs[0] ) || words[i].Contains( signs[1] ) )
                    stb.Append( @"\n" );
                //else if (  )
                else
                    stb.Append( ' ' );
            }

            return result;
        }
    }
}
