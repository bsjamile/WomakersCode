﻿// Console.WriteLine('Hello World!');
//O C# não aceita aspas simples ('')

Console.Write("Congratulations!");

Console.Write(" ");

Console.WriteLine("You wrote your first lines of code!");

// or.. it's the same!

Console.WriteLine("Congratulations! ");

// A próxima linha vai aparecer em outro parágrafo por causa da função 'WriteLine"

Console.WriteLine("You wrote your second lines of code!");

Console.WriteLine("Hello World!");
// O C# só aceita asplas duplas ("")

Console.WriteLine("This is the first line.");

Console.WriteLine("This is the second line.");

Console.Write("This is ");
Console.Write("the second");
Console.WriteLine(" line.");

Console.WriteLine('b');
// Apenas um único caractere alfanumérico impresso na tela, poderíamoso criar um literal char circundando um caractere alfanumérico com aspas simples.

Console.WriteLine(120);
Console.WriteLine(12.3m);
// O m pode ser maiúsculo ou minúsculo

Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("123");
Console.WriteLine(123);
Console.WriteLine("true");
Console.WriteLine(true);

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

char userOption;
userOption = 'J';
Console.WriteLine(userOption);

int gameScore;
gameScore = 1;
Console.WriteLine(gameScore);

decimal particlesPerMillon;
particlesPerMillon = 1.0m;
Console.WriteLine(particlesPerMillon);

bool processedCustomer;
processedCustomer = true;
Console.WriteLine(processedCustomer);

string myName;
myName = "Jamile";
//"Jamile = myName; (não funciona. Só do outro modo)
Console.WriteLine(myName);

string myNickname;
myNickname = "Mile";
Console.WriteLine(myNickname);

// int myNickname;
// myNickname = "Jam";
// Console.WriteLine(myNickname);
// O C# foi projetado para impor tipos, 
// O que significa que você não pode atribuir um valor de um tipo de dados a uma variável declarada com a finalidade de conter um tipo de dados diferente.

firstName = "Beth";
Console.WriteLine(firstName);
firstName = "Conrad";
Console.WriteLine(firstName);
firstName = "Grant";
Console.WriteLine(firstName);
firstName = "Maricota";
//Inicializar uma variável
Console.WriteLine(firstName);

// string firstName;
// Console.WriteLine(firstName);
// É preciso definir uma variável como um valor antes de poder obter o valor da variável.

var message = "Hello World!";
Console.WriteLine(message);
message = "Olá!";
Console.WriteLine(message);
// a partir daí, a variável message só aceita dados do tipo string.

string nameDog = "Bob";
int numberInbox = 3;
decimal temperature = 34.4m;
Console.Write("Hello, ");
Console.Write(nameDog);
Console.Write("! You have ");
Console.Write(numberInbox);
Console.Write(" messages inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

Console.WriteLine("Hello\nWorld!");
// \n adicionará uma nova linha

Console.WriteLine("Hello\tWorld!");
// \t adicionará um espaço em branco

Console.WriteLine("Hello \"World\"!");
// \" para colocar entre aspas

// Console.WriteLine("c:\source\repos"); dá erro porque a \ é reservada para sequências de escape. \s e \r são sequências de escape
// Então, quando precisarmos colocar um nome de um local ou algo do tipo, precisamos adicionar uma segunda \. Ex:
Console.WriteLine("c:\\source\\repos");

Console.Write("Generating invoices for cusromer \"ABC Corp\"...\n");
Console.Write("Invoice:2021\t\tComplete!\n");
Console.WriteLine("Invoice 1022\t\tComplete!");
Console.WriteLine("Output Directory:\t");
Console.WriteLine(@"c:\invoices");

// as sequeências de escape: \t - espaço em braanco ; \n pula uma linha ; \" Jmile \" coloca aspas em Jmile
// o @ antes de tudo faz com que não seja necessário o uso das duas barras (\\)
Console.WriteLine(@"c:\source\repos
    (this is where your code goes)");
Console.WriteLine(@"c:\invoices");

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u306F World!");

// To generate Japanese invoices:
// Nihon no seikyu-sho o seisei suru ni wa:
Console.Write("\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

// Concatenar Valores
// operador de concatenação = +
message = "Hello " + firstName;
Console.WriteLine(message);

string getting = "Hello";
Console.WriteLine(getting + " " + firstName + "!");
message = $"{getting} {firstName}!!!!!!!!!!!";
Console.WriteLine(message);

//Interpolação pode criar um modelo com $
myName = "Jamile";
message = $"Hello {firstName} e {myName}!";
Console.WriteLine(message);
// Não criar variáveis intermediárias
Console.WriteLine($"{getting} {firstName} e {myName}!");

Console.WriteLine($"Olá! Eu gostaria de conhecer {firstName} e {myName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projetoNome = "ACME";
string englishLocation = $@"c:\Exercise\{projetoNome}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMensagem = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c  \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMensagem}:\n\t\t{russianLocation}\n");


//string projetoNome = "ACME";
//string russianMensagem = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c  \u0440\u0443\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
    c:\Exercise\{projetoNome}\data.txt");
Console.WriteLine($@"{russianMensagem}:
    c:\Exercise\{projetoNome}\ru-RU\data.txt");