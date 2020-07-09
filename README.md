# 8-) **PROJETO ENTRA21** 8-)

### Escrevendo e Lendo do Console:

    //Escrever mensagem
    Console.WriteLine("mensagem");
    
    //Ler input e salvar em var
    var userInput = Console.ReadLine();

### Tipos Básicos:

    // Tipo numérico/int
    var number = 1;

    // Tipo texto/string
    var text "meu texto";

    // Tipo booleano/bool
    var boolean = true;

    // Tipo numérico com ponto flutuante/double
    var price = 4.099;

### Parsers / Transformadores:

    //Transformar um texto em um número/int
    var numComoInt = Int32.Parse(numComoString);

### Operadores:
#### Operadores de Comparação:
##### (obs: Toda comparação retorna um booleano/bool)

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

#### Operadores de Comparação para Números:

    // É maior?
    1 > 1; //retorna false
    
    // É menor?
    1 < 1; //retorna false

    // É maior OU igual?
    1 >= 1; //retorna true

    // É menor OU igual?
    1 <= 1; //retorna true

#### Operadores de Matemática:

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