using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'a'; //char uses single quotes
            var firstName = "Dicky"; //string uses double quotes
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}

//Notes:

// variables are declared by giving it a type and then the name - 
// int uno = 1;
// you don't have to assign a variable an intial value, but you can't use it until you do initialize it

// constants can be declared using the keyword const, then a type and name -
// const int Dos = 2;
// a const must have an initial value

// common naming convention is camelCase for variable and PascalCase for constants

// when declaring certain types, you must include a suffix to the value - 

// float myFloat1 = 3.14f; - Specifying a float
// double myDoubleExplicit = 3.14d;  - Explicitly specifying double (double is the default)
// decimal myDecimal = 3.14m;  - Specifying a decimal
// long myLong = 314L;  - Specifying a long
// uint myUInt = 314u;  - Specifying an unsigned int
// ulong myULong = 314ul;  - Specifying an unsigned long
