// See https://aka.ms/new-console-template for more information
using RefAndOut;

Console.WriteLine("Hello, World!");


//ref
int NumbeRef = 0;
Console.WriteLine("NumbeRef is: " + NumbeRef);
Caculator caculator = new Caculator();
caculator.GetRefValue(ref NumbeRef);

Console.WriteLine("NumbeRef is: " + NumbeRef);


//out
int NumberOut;
caculator.GetOutValue(out NumberOut);

Console.WriteLine("NumberOut is: " + NumberOut);
Console.WriteLine("NumberOut is: " + ++NumberOut);

Console.ReadKey();