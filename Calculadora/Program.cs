// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

while(true)
{
    Console.WriteLine("Ingrese la opcion de la operacion que desea ejecutar, solo enteros!");
    Console.WriteLine("1.Suma");
    Console.WriteLine("2.Resta");
    Console.WriteLine("3.Multiplicacion");
    Console.WriteLine("4.Division");
    string n = Console.ReadLine();
    int num1;
    int num2;
    Console.WriteLine("Variable 1");
    num1 = ingresarNumero();
    Console.WriteLine("Variable 2");
    num2 = ingresarNumero();
    switch (n)
    {
        case "1":
            Console.WriteLine("Suma");
            break;
        case "2":
            Console.WriteLine("Resta");
            break;
        case "3":
            Console.WriteLine("Multiplicaion");
            break;
        case "4":
            Console.WriteLine("Division");
            break;
       
    }
}


int ingresarNumero()
{
    (int, bool) r;
    do
    {
        Console.WriteLine("Ingrese numero");
        string n = Console.ReadLine();
        r = validarNumero(n);
    } while (!r.Item2);
    return r.Item1; 
}
(int,bool) validarNumero(string n)
{
    int i;
    bool success = int.TryParse(n, out i);
    return (i,success);
}

float division(float num1,float num2)
{
    return num1 / num2; 
}

int multiplicacion (int num1,int num2)
{
    return num1 * num2; 
}