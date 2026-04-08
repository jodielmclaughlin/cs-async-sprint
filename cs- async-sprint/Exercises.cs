using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace cs__async_sprint
{
    public class Exercises
    {
        public static BigInteger CalculateFactorial(BigInteger num)
        {
            BigInteger result = BigInteger.One;
            for (BigInteger i = BigInteger.One; i.CompareTo(num) <= 0; i = BigInteger.Add(i, BigInteger.One))
            {
                result = BigInteger.Multiply(result, i);
            }
            return result;
        }

        public async Task PrintStoryByWord()
        {
            string story = "Mary had a little lamb, its fleece was white as snow.";
            var storySplit = story.Split(' ');
            foreach (var word in storySplit)
            {

                
                Console.WriteLine(word);
                await Task.Delay(1000);

                //foreach, console.writeline, task.delay,

            }
        }
    }
}
