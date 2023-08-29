// See https://aka.ms/new-console-template for more information

int num1, num2, num3;

Console.WriteLine("\tPrograma para saber el mayor de tres números");
Console.WriteLine("\t********************************************\n");
Console.Write("Inserte el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Inserte el segundo número: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Inserte el tercer número: ");
num3 = int.Parse(Console.ReadLine());

if (num1 != num2 && num1 != num3 && num2 != num3)
{
    if (num1 > num2 && num1 > num3)
        Console.WriteLine("El número mayor es: {0}", num1);
    if (num2 > num1 && num2 > num3)
        Console.WriteLine("El número mayor es: {0}", num2);
    if (num3 > num1 && num3 > num2)
        Console.WriteLine("El número mayor es: {0}", num3);
}
else
    Console.WriteLine("¡Error! Debe colocar tres números diferentes entre sí");

Console.ReadKey();