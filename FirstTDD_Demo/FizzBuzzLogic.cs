using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTDD_Demo
{
    public class FizzBuzzLogic
    {
        public string DoTheThing(int p)
        {
            string answer = "";

            if(p % 3 != 0 && p % 5 != 0)
            answer = p.ToString();
            else
            {
                answer = (p % 3 == 0) ? "Fizz" : string.Empty;
                answer += (p % 5 == 0) ? "Buzz" : string.Empty;
            }
            
            return answer;
        }
    }
}
