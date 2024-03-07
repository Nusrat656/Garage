using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Schema;

class Program
{

   
    static void Main(string[] args)
    {
        Console.WriteLine(MaxValue(36,38, 46,60,120));
    }
    static int MaxValue(int num1, int num2, int num3)
    {
        int max;

        if (num1 > num2)
        {
            max = num1;
        }
        else if (num2 > num3)
        {
            max = num2;
        }
        else
        {
            max = num3;
        }
        return max;
    }
    static int MaxValue(int num1, int num2, int num3, int num4)
    {
        int max= MaxValue(num1, num2, num3);
        if (num4 > max)
        {
            return num4;
        }
        else
        {
            return max;
        }
        
    }

    static int MaxValue(int num1, int num2, int num3, int num4, int num5)
    {
        int max = MaxValue(num1, num2, num3,num4);
        if (num5 > max)
        {
            return num5;
        }
        else
        {
            return max;
        }

        
    }
}
















