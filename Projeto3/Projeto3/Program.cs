//declarei as variaveis com o valor padrao 0 
int a = 0;
int b = 0;

//pede para digitar o primeiro valor e lê ele
Console.WriteLine("Digite o primeiro valor: ");

string a1 = Console.ReadLine(); //declaro a variavel em string para ser lida pelo Console.ReadLine()

Console.WriteLine();

//pede para digitar o segundo e lê
Console.WriteLine("Digite o segundo valor: ");

string b1 = Console.ReadLine(); //declaro a variavel em string para ser lida pelo Console.ReadLine()

//converte o valor de string para int usando Parse
a = int.Parse(a1);
b = int.Parse(b1);

//variáveis para fazer os cálculos
int soma = a + b;
int subi = a - b;
int multi = a * b;
int divi = a / b;
int resto = a % b;

Console.WriteLine();

Console.WriteLine($"O cálculo dos valores {a} e {b} é:");

Console.WriteLine();

//mostra o resultado de tudo
Console.WriteLine($"Soma é: {soma}");
Console.WriteLine($"Subtração é: {subi}");
Console.WriteLine($"Multiplicação é: {multi}");
Console.WriteLine($"Divisão é: {divi}");
Console.WriteLine($"Resto da divisão é: {resto}");

// Correção no uso do string.Format e na impressão
string msgTemplate = "[{0:yyyy-MM-dd HH:mm:ss}] A soma entre {1} e {2} é {3}.";
string resultadoFormatado = string.Format(msgTemplate, DateTime.Now, a, b, soma);
Console.WriteLine(resultadoFormatado);

Console.WriteLine($"A divisão entre {a} e {b} é {divi}");

