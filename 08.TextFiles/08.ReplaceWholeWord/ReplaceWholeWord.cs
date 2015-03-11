/*Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

class ReplaceWholeWord
{
    static void Main()
    {
        
        Regex wordRgx = new Regex("\bstart\b", RegexOptions.IgnoreCase);

        using (StreamReader sr = new StreamReader("../../text.txt"))
        {
            using (StreamWriter sw = new StreamWriter("../../output.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(wordRgx.Replace(line, "finish"));
                }
            }
        }        
    }
}

