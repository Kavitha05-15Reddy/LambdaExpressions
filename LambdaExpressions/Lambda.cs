using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Lambda
    {
        //Expression
        public void Square()
        {
            var square = (int num) => num * num;
            Console.WriteLine("Square:"+square(5));
        }
        //Statement
        public void Sum()
        {
            var sum = (int a, int b) =>{return a + b;};
            Console.WriteLine("Sum:"+sum(5,6));
        }
        //Delegate
        public void Multiply()
        {
            Func<int,int,int> mulitiply = (a,b) => a * b;
            Console.WriteLine("Mutliplication:" + mulitiply(5, 8));
        }
        //Array
        public void Count()
        {
            int[] num = { 2, 13, 1, 4, 13, 5 };
            int length = num.Length;
            int count = num.Count(x => x == 13);
            Console.WriteLine("Length:" + length);
            Console.WriteLine("Count:" + count);
        }
    }
}
