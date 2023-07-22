using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutof
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<char> characters = new List<char>();
            characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
            int value = characters[6];
            try
            {
                List characters = new List();
                characters.InsertRange(0, new char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                int value = characters[6];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
