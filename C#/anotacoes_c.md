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