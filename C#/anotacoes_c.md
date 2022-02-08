# C#

- Na linguagem C# as funções built-in são diferenciadas por M e m (Maiúsculo e minúsculo); 
    Console =! console
- A linguagem também não aceita as pasas simples (''). Apenas as duplas ("");

- Erros comuns cometidos por programadores não experientes:
    - Inserir letras minúsculas em vez de colocar C em maiúsculas em Console ou as letras W ou L em WitreLinte --------- Console.WriteLine("Heelo World!");
    - Inserir uma vírgula em vez de um ponto entre Console e WriteLine.
    - Esquecer de usar aspas duplas ou colocar a frase Hello World! entre aspas simples.
    - Esquecer de usar o ponto e vírgula no final do comando.
(Cada um desses erros impede que o código seja compilado com êxito)

- // Para comentar com C#

- As classes agrupam métodos que realizam funções semelhantes. Ex: Console(é a classe). WriteLine(é o método - todos os métodos que operam no painel de Saída são definidos na classe Console).
    - O método sempre será seguido de parênteses.
    - A classe e o método são separados por um ponto (.). O ponto é a forma como você "navega da classe para um dos métodos dela.
    - O ; informa ao compilador que terminamos de inserir o comando. 

# Valor Literal
    - É um valor embutido em código que nunca é alterado.
    - Apenas um único caractere alfanumérico impresso na tela, poderíamoso criar um literal char circundando um caractere alfanumérico com aspas simples.
    - Assim como o tipo de dados String, você usa char sempre que tem um único caractere alfanumérico para apresentação (não para cálculo).
        O termo char é a abreviaão de caractere em inglês.
    - Número inteiro = int
    - Sufixo Literal - A letra m = informa ao compilador que você deseja trabalhar com um valor do tipo decimal. Ex: "Console.WriteLine(12.3m);". O m pode ser maiúsculo ou minúsculo;
    - Literal bool - bool - true ou false
    - string e char são usados para "apresentação, não cálculo". Se precisar executar uma operação matemática em valores numéricos, você deverá usar um int ou decimal.

# Variável
- Para usar uma variável, você precisa primeiro declará-la;
- Para criar uma variável primeiro deve-se declarar o tipo de dados da variável e, em seguida, dar um nome a ela. Ex: "string firstName;"
    - Os nomes das variáveis diferenciam maiúsculas de minúsculas, ou seja, string Value; =! string value;
    - Os nomes das varipaveis devem usar minúsculas concatenadas. Ex: string thisIsCamelCase;
    - O nome da variável deve ser uma ou mais palavras inteiras unidas. Não use contrações!
    - O nome da variável não deve ncluir o tipo de dados da variável.
- O C# foi projetado para impor tipos, o que significa que você não pode atribuir um valor de um tipo de dados a uma variável declarada com a finalidade de conter um tipo de dados diferente.
    - Recuperar um valor de uma variável = obter a variável = operação "get".
    - É possível reutilizar e reatribuir a variável quants vezes desejar. 
    - É preciso definir uma variável como um valor antes de poder obter o valor da variável.
    - Variáveis locais do tipo implícito - é criado usando a palavr-chave var - faz com que o C# infira o tipo de dados daquela variável. Ex: var message = "Hello world!";
# Sequência de Escape
    - \n adicionará uma nova linha;
    - \t adicionará uma guia;
    - \" para colocar entre aspas. Ex: \"World\"  
    - Se quiser digitar um caminho dá erro porque o C# resenva a barra invertida para sequências de escape. Ex de erro: Console.WriteLine("c:\source\repos");. \s e \r é uma sequência de escape. Ex dsem erro: Console.WriteLine("c:\\source\\repos");
    - A diretiva @ antes da cadeia de caracteres literal faz com que não seja necessário usar as \\
        Ex: Console.WriteLine(@"c:\source\repos");
    - \u converte um código de quatro caracteres representando algum caractere em unicode (UTF-16), por exemplo.
--------------------
### Recapitulando:
- Use as sequências de escape de caractere quando precisar inserir um caractere especial em uma cadeia de caracteres literal, como uma tabulação \t, uma nova linha \n ou uma aspa dupla \".
- Use um caractere de escape para a barra invertida \\ quando precisar usar uma barra invertida em todos os outros cenários.
- Use a diretiva @ para criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço em branco e caracteres de barra invertida em uma cadeia de caracteres.
- Use o \u mais um código de quatro caracteres para representar caracteres Unicode (UTF-16) em uma cadeia de caracteres.
- Os caracteres Unicode podem não ser impressos corretamente dependendo do aplicativo.
-----------------------
# Concatenação
- Combinar dois ou mais valores em um novo valor.
- Operador de concatenação de cadeia de caracteres = +.
- Evitar usar variáveis intermediárias (uma variável que resulte da soma de outras 2 ou maisvariáveis).

# Interpolação
- Combina vários valores em uma única cadeia de caracteres literal usando um "modelo" e uma ou mais expressões de interpolação.
    Para se tornar um modelo, a cadeia de caracteres literal quando é prefixado pelo caractere $.

- Sobrecarregar os operadores = o operador de adição, que é o símbolo de mais, é utilizado tanto para somar quanto para concatenar as cadeias de caracteres.
    Considerando os tipos de dados das variáveis (ambos são ints), ele conclui que você deseja adicionar os dois valores.