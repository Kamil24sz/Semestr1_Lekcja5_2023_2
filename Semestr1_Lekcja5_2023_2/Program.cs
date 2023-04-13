using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja5_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //a) Co to jest Windows Forms
            //b) Co to jest TextBox, co to jest Button ?
            // textbox - służy do wpisywania informacji od użytkownika
            // button - przycisk 
            //c) Co to jest rzutowanie? Do czego służy?
            //double a = 3.18;
            //int b = (int)a; // b = 3 

            //Operatory matematyczne i logiczne.

            //1.OPERATORY MATEMATYCZNE

            //operator większości
            bool test = 10 > 3;
            Console.WriteLine($"10 > 3 = {test}");

            //operator mniejszości
            test = 10 < 3;
            Console.WriteLine($"10 < 3 = {test}");

            //operator większy bądź równy
            test = 10 >= 3;
            Console.WriteLine($"10 >= 3 = {test}");

            //operator mniejszy bądź równy
            test = 3 <= 3;
            Console.WriteLine($"3 <= 3 = {test}");

            int a = 10;
            double b = 10;

            //operator równości  2 ZNAKI =  (==)
            test = a == b;
            Console.WriteLine($"{a} == {b} = {test}");

            //operator nierówności
            test = a != b;
            Console.WriteLine($"{a} != {b} = {test}");

            //2.OPERATORY LOGICZNE

            // &&  -  nazywa się "i"  wszystkie warunki muszą być spełnione aby wartość była true
            test = 10 == 10 && 2 < 3 && a == b && 10 < 2;
            //       true  &&  true  &&  true  &&  false =>   false
            Console.WriteLine($"10 == 10 && 2 < 3 && a == b && 10 > 2 = {test}");

            // ||  -  nazwa się "lub"  jeden warunek musi być spełniony aby wartość była true
            test = 10 < 2 || 2 == 2 || a != b;
            //      false ||  true  ||  false => true
            Console.WriteLine($"10 < 2 || 2 == 2 || a != b = {test}");

            // !  -  operator negacji  zmienia wartość logiczną na przeciwną
            test = true;
            test = !test;  // false 

            // test = !(10 == 10);


            Console.Clear();

            Console.WriteLine( 3 <= 3 && !(10 == 10)  && 2 * 2 == 4 );
            //                  true  &&    false     &&   true   =>  false


            Console.Clear();

            //inkrementacja
            int x = 5;
            x++; // to to samo co x = x + 1;  dodaje 1 do wartości zmiennej
            Console.WriteLine(x);

            //dekrementacja
            int y = 5;
            y--; // to to samo co y = y - 1; odejmuje 1 od wartości zmiennej
            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
