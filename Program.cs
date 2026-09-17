//// adoro comer cimento
///*
//Receba é o caba da luva de pedreiro(comentario de mutiplas linhas)
//*/
////mostro texto na tela

////toda instrução termina com;
//Console.WriteLine("RECEBA, é o caba da luva de pedreiro!");

////guardar informções
////1. variaveis (caixinhas que guardam informações)

////Tipo NOME_DA_VARIAVEL = Valor;
//int idade = 16;
//Console.WriteLine(idade);
//string nome = "Samuel";
//Console.WriteLine(nome);

//// int - integer (Numeros inteiros)
////double - Numeros quebrados (float faz o mesmo, mas guardar números menors que double)
////string - Textos - ""

////Const - é um valor que não pode se alterado
//const double PI = 3.14159;
//Console.WriteLine(PI);

//// var - o C# tenta entender qual é a classificação do código, nesse caso string
//var nome1 = "Lucas";
////nesse caso double
//var preco = 19.55;
//// char - unico digito, e uso de ' ao invés de "
//char inicialDoNome = 's';

//Console.WriteLine("Digite seu nome");
//string nomeUsuario = Console.ReadLine();

//Console.WriteLine("INFORME SUA IDADE");
////Parse - convete o tipo para váriavel inteira
//int idadeUsuario = int.Parse(Console.ReadLine());

//Console.WriteLine("Olá. " + nomeUsuario + "! \n VocÊ tem " + idadeUsuario + " anos.");

////Interpolacao de strings
//Console.WriteLine($"Olá, {nomeUsuario}! você tem {idadeUsuario} anos)");

//operações aritimeticas

//int soma = 10 + 15;
//int sub = 10 - 5;
//int multiplicação = 10 * 5;
//int divisão = 10 / 2;

//resto da divisão - recebe o resto da divisão do exponte pelo divivdendo
//int modulo = 10 % 3;

//Console.WriteLine(soma);
//Console.WriteLine(sub);
//Console.WriteLine(multiplicação);
//Console.WriteLine(divisão);
//Console.WriteLine(modulo);

//Exericios fundamentais
//1. Hello world
Console.WriteLine("Hello! World");

//2. Declarar uma váriavel inteira
int numero = 10;
Console.WriteLine(numero);

//3. Fazer uma soma com duas váriaveis
int som1 = 5;
int som2 = 3;
Console.WriteLine(som1 + som2);

//4. mutiplicação de duas variaveis 
int mult1 = 8;
int mult2 = 7;
Console.WriteLine(mult1 * mult2);

//Exercicios intermediários
//5. saudação personalizada
string nome = "Ana";
Console.WriteLine($"Olá, {nome} seja bem vinda");

//6. calcular o dobro
int dobro = 10;
Console.WriteLine(dobro * 2);

//7. média de três números
int num1 = 10;
int num2 = 20;
int num3= 30;
Console.WriteLine(num1 %3);
Console.WriteLine(num2 %3);
Console.WriteLine(num3 %3);

//8.ficha de cadastro
Console.WriteLine("dígite seu nome");
string nome1 = Console.ReadLine();
Console.WriteLine("dígite sua idade.");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("dígite sua cidade");
String cidade = Console.ReadLine();
Console.WriteLine($"Olá, {nome1}, você tem {idade} anos, e mora em {cidade}");

//9.Comparar dois números
int x = 10;
int y = 20;
if (x < y)
{
    Console.WriteLine($"{x} é menor que {y}");

} else { Console.WriteLine($"{x} é maior que {y}"); }

//Exércicios 