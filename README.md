# **PROJETO ENTRA21**

## Escrevendo e Lendo do Console:

    //Escrever mensagem
    Console.WriteLine("mensagem");
    
    //Ler input e salvar em var
    var userInput = Console.ReadLine();

## Declarando Variáveis e Constantes:

    var text = "meu texto";
    string text = "meu texto";
    const string text = "meu texto";

## Tipos Básicos:

    // Tipo numérico/int
    var number = 1;

    // Tipo texto/string
    var text "meu texto";

    // Tipo booleano/bool
    var boolean = true;

    // Tipo numérico com ponto flutuante/double
    var price = 4.099;

    // Tipo Data e Hora/DateTime
    var currentDate = DateTime.Now;

## Parsers / Transformadores:

    //Transformar um texto em um número/int
    var numComoInt = Int32.Parse(numComoString);

## Operadores:
### Operadores de Comparação:
#### (obs: Toda comparação retorna um booleano/bool)

    // É igual?
    false == false; //retorna true
    
    // É diferente?
    1 != 1; //retorna false

    // É diferente?
    !(1 == 1); //retorna false

    // Booleano da esquerda é true E o da direita também?
    true && true; //retorna true

    // Booleano da esquerda OU o da direita é true?
    true || false; //retorna true

### Operadores de Comparação para Números:

    // É maior?
    1 > 1; //retorna false
    
    // É menor?
    1 < 1; //retorna false

    // É maior OU igual?
    1 >= 1; //retorna true

    // É menor OU igual?
    1 <= 1; //retorna true

### Operadores de Matemática:

    // Somar
    1 + 1; //retorna 2

    // Subtrair
    1 - 1; //retorna 0

    // Dividir
    2 / 1; //retorna 2

    // Multiplicar
    1 * 2; //retorna 2

    // Resto
    3 % 2; //retorna 1

## Blocos Condicionais:

    // SE 1 > 0 escrever "Olá"...
    if(1 > 0)
    {
      Console.WriteLine("Olá");
    }
    // SENÃO, SE 2 > 1 escrever "Salve"...
    else if(2 > 1)
    {
      Console.WriteLine("Salve");
    }
    // SENÃO, escrever "Adeus"
    else
    {
      Console.WriteLine("Adeus");
    }

## Comandos do Editor:
Comentar texto selecionado: Ctrl + K + C

Descomentar : Ctrl + K + U

UNDO: Ctrl + Z

REDO: Ctrl + Y

Abrir o terminal: Ctrl + '

## Depurando a Aplicação:
1. Debug/Run -> Settings -> '.Net Core'
2. launch.json -> "console": "integratedTerminal";
3. Adicionar Breakpoints -> Ponto vermelho à esquerda do n° da Linha
4. Start -> Selecionar Terminal
5. F10 = Próximo Passo, F5 = Próximo Breakpoint
6. Shift + F5 = Abortar, Ctrl + Shift + F5 = Recomeçar