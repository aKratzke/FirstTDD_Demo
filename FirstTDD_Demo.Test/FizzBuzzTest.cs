using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FirstTDD_Demo.Test
{
    public class FizzBuzzTest   
    {
        [Fact]
        public void ReturnedNumberAsString()
        {
            var ourTest = new FirstTDD_Demo.FizzBuzzLogic();

            string answer = ourTest.DoTheThing(1);

            Assert.Equal("1", answer);
        }
        [Fact]
        public void NumberDividedByThree()
        {
            var ourTest = new FirstTDD_Demo.FizzBuzzLogic();
            string answer = ourTest.DoTheThing(3);

            Assert.Equal("Fizz", answer);
        }
    }
}
