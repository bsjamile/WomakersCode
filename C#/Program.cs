// Console.WriteLine('Hello World!');
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
firstName = "Dani";
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
