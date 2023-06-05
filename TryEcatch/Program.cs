using System;

try
{

    Console.WriteLine("Informe o primeiro valor: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o segundo valor: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = a / b;

    Console.WriteLine($"O resultado é {result}");

}


catch(DivideByZeroException e) //expecifico divisao por zero
{
    Console.WriteLine($"Não é permitido dividir por zero " + e.Message); //imprimindo a mensagem de erro
}

catch(FormatException e)
{
    Console.WriteLine($"Conversão de string para letra não é permitida! { e.Message}");
}

catch(Exception e) //geral, tem que estar por ultimo
{
    Console.WriteLine($"Ocorreu um erro {e.Message}");
}

finally     //independente se deu certo ou errado vai passar no finally
{
    Console.WriteLine("Aqui passa de qualquer forma!");
}



Console.ReadKey();
