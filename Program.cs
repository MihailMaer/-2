
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Прак2;


start:

Cl clas = new Cl();

string simb;
double x;
double y;

Console.WriteLine("Ввести первое число");
try
{
    x = Convert.ToDouble(Console.ReadLine());
}
catch (Exception)
{

    x = 0;
}


Console.WriteLine("ввести действие");
simb = Convert.ToString(Console.ReadLine());


Console.WriteLine("ввести второе число");
try
{
    y = Convert.ToDouble(Console.ReadLine());
}
catch (Exception)
{

    y = 0;
}


switch (simb)
        {
         case "+":
                clas.summa(x, y);
                goto start;
            case "-":
                clas.minuc(x, y);
                goto start;
            case "*":
                clas.multiplications(x, y);
                goto start;
            case "/":
                clas.division(x, y);
                goto start;
            case "sin*":
                clas.sinmultiplications(x, y);
                goto start;
            case "cos*":
                clas.cosmultiplications(x, y);
                goto start;
            case "sin/":
                clas.sindivision(x, y);
                goto start;
            case "cos/":
                clas.cosdivision(x, y);
                goto start;
            case "tan*":
                clas.arsinmultiolications(x, y);
                goto start;
            case "log*":
                clas.arcosmultiplications(x, y);
                goto start;
            case "S-TR":
                clas.PlTR(x, y);
                goto start;
            case "S-C-D":
                clas.ScIRCLeD(x, y);
                goto start;
            case "S-C-R":
                clas.ScIRCLeR(x, y);
                goto start;
            case "S-K":
                clas.SKV(x, y);
                goto start;
        }