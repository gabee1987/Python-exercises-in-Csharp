using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _61_exercise.Engine
{
    public class SentenceSeparator
    {
        public static string SeparateText( string baseText )
        {
            string result  = string.Empty;
            string[] signs = new string[2]{"?", "!" };
            var words      = baseText.Split(' ');
            words          = words.Where( w => !string.IsNullOrEmpty(w) ).ToArray();
            //Console.WriteLine( words );

            

            StringBuilder stb = new StringBuilder();

            for ( int i = 0; i < words.Length; i++ )
            {
                stb.Append( words[i] );
                // if ? and ! sign, thats end of sentence
                if ( words[i].Contains( signs[0] ) || words[i].Contains( signs[1] ) )
                {
                    stb.Append( Environment.NewLine );
                    continue;
                }
                else if ( i <= words.Length - 2  )
                {
                    if ( words[i] == "Mr." || words[i] == "Mrs." || words[i] == "Dr." )
                    {
                        stb.Append( " " );
                        continue;
                    }
                    // If actually end of sentence
                    if ( words[i][words[i].Length - 1] == '.' && (Char.IsUpper( words[i + 1][0] ) || Char.IsDigit( words[i + 1][0] ) ) )
                    {
                        stb.Append( Environment.NewLine );
                        continue;
                    }
                }
                stb.Append( " " );
            }

            result = stb.ToString();
            return result;
        }
    }
}
