using System;

namespace calc
{
    public class Calc
    {

        public static void Main(string[] args)
        {

            // string str = Console.ReadLine();
            int result = 0;
            result = calculator("1,2,-3");
            Console.WriteLine(result.ToString());
        }
        public static int calculator(string str)
        {
            string delimeter = ",";
            int result = 0;
            int index = 0;

            if (str.Contains("\n"))
            {
                if (str.Contains("//"))
                {
                    str = str.Replace("//", "");
                    index = str.IndexOf("\n");
                    delimeter = str.Substring(0, index);
                    char[] c;
                    if (delimeter.Length > 1)
                    {

                        for (int i = 0; i < index ; i++)
                        {
                            c = delimeter.Substring(i, 1).ToCharArray();
                            str = str.Replace(c[0], ',');
                        }
                         delimeter = ",";
                    }

                    str = str.Substring(index + 1, str.Length - index - 1);
                }

                str = str.Replace("\n", "");
            }
            
            if (!string.IsNullOrEmpty(str))
            {
                result = AddArray(str, delimeter);
            }

            return (result);
        }
        public static int AddArray(String str, string delimeter)
        {
            int result = 0;
            string strException ="";
           
            string[] strArray = str.Split(delimeter);

           
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Trim() != "")
                {
                    int number = int.Parse(strArray[i]);  

                     if (number < 0)
                          strException=  strArray[i] + "," ;
                    if (number > 1000)
                        number = 0;
                    result = result + number;
                }
            }
            if (!string.IsNullOrEmpty(strException))
             throw new Exception("Negatives not allowed: "  + strException.Substring(0,strException.Length-1)); 

            return result;
        }

    }
}
