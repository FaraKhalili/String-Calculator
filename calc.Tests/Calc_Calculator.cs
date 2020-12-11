using System;
using Xunit;



namespace calc.Tests
{
    public class Calc_Calculator
    {
        [Fact]
        public void TestCalc()
        {
            string str = "1,2,3";
            int res = Calc.calculator(str);
            Assert.Equal(res, 6);

            str = "";
            res = Calc.calculator(str);
            Assert.Equal(res, 0);

            str = "1\n,2,3";
            res = Calc.calculator(str);
            Assert.Equal(res, 6);

            str = "1,\n2,4";
            res = Calc.calculator(str);
            Assert.Equal(res, 7);

            str = "//;\n1;3;4";
            res = Calc.calculator(str);
            Assert.Equal(res, 8);

            str = "//$\n1$2$3$";
            res = Calc.calculator(str);
            Assert.Equal(res, 6);

            str = "//@\n2@3@8";
            res = Calc.calculator(str);
            Assert.Equal(res, 13);

            str = "2,1001";
            res = Calc.calculator(str);
            Assert.Equal(res, 2);

            str = "//***\n1***2***3";
            res = Calc.calculator(str);
            Assert.Equal(res, 6);

            str = "//$,@\n1$2@3";
            res = Calc.calculator(str);
            Assert.Equal(res, 6);

            str = "//$,@\n1$2@$,@3";
            res = Calc.calculator(str);
            Assert.Equal(res, 6);

            try
            {
                str = "1,2,-3";
                res = Calc.calculator(str);
            }
            catch (Exception e)
            {
                Assert.Equal("Negatives not allowed", e.Message);
            }
        }




    }
}
