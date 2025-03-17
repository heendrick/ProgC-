using System;

class Aula_03
{
    static void Main()
    {
        byte n1 = 10; // 0 a 255
        int num = 10; // -2.147.483.648 a 2.147.483.647
        char letra = '9'; // 1 caracter
        float valor = 5.3f; // 4 bytes
        string nome = "Hendrick"; // texto
        var aux = num; // inferencia de tipo automaticamente pelo compilador ao identificar o valor
        
        Console.WriteLine("Valor da variável: " + aux);
        Console.WriteLine("Hello, World!");

        int num1,num2,res;

        num1 = 10;
        num2 = 2;

        //console.WriteLine("Digite um número: " + num1 + " e " + num2);
        res = num1 + num2;
        
        Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a " + res);
    }
}
