static void exercicio01()
{
    // Solicitar o nome de 4 pacientes
    int i = 0;
    while (i < 4)
    {
        Console.Write("Digite o nome do paciente: ");
        string nomePaciente = Console.ReadLine();
        if (nomePaciente == "" || nomePaciente.Trim().Length < 3 || nomePaciente.Trim().Length > 50)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nome inválido!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Nome do paciente: " + nomePaciente);
            i++;
        }
    }
    Console.WriteLine("Número de pacientes: " + i + " pacientes.");
}
//exercicio01();

static void exercicio02()
{
    //Solicitar o nome, peso e altura de 3 atletas, calculando e apresentando seu imc
    int i = 0;
    double pesoAtleta, alturaAtleta = 0;
    string nomeAtleta = "";

    while (i < 3)
    {
        Console.Write("Digite o nome do " + (i + 1) + "º atleta: ");
        nomeAtleta = Console.ReadLine().Trim();
        Console.Clear();

        // Validando peso
        try
        {
            Console.Write("Digite o peso de " + nomeAtleta + ": ");
            pesoAtleta = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor inválido!\nEscreva o peso como no exemplo: 85 (kg)");
            Console.ResetColor();

            Console.Write("Digite novamente o peso de " + nomeAtleta + ": ");
            pesoAtleta = Convert.ToDouble(Console.ReadLine());
        }
        Console.Clear();

        //Validando altura
        try
        {
            Console.Write("Digite a altura de " + nomeAtleta + ": ");
            alturaAtleta = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor inválido!\nEscreva a altura como no exemplo: 1,75 (m)");
            Console.ResetColor();

            Console.Write("Digite novamente a altura de " + nomeAtleta + ": ");
            pesoAtleta = Convert.ToDouble(Console.ReadLine());
        }

        double imc = pesoAtleta / (alturaAtleta * alturaAtleta);
        Console.WriteLine("Nome: " + nomeAtleta +
            "\nPeso: " + pesoAtleta + "kg" +
            "\nAltura: " + alturaAtleta + "m" +
            "\nImc: " + imc + "m/cm2\n");

        Console.Write("Pressione enter para continuar");
        string proximo = Console.ReadLine();

        Console.Clear();
        i++;
    }
}
//exercicio02();

static void exercicio03()
{
    //Solicitar o nome, sobrenome, nota 1, nota 2 e nota 3 de 5 alunos. Calcular a média e apresentar
    string nome, sobrenome, situacao = "";
    double n1, n2, n3, mediaNotas = 0;
    int i = 0;

    while (i < 5)
    {
        Console.Write("Digite o nome do " + (i + 1) + "º aluno: ");
        nome = Console.ReadLine().Trim();

        Console.Write("Digite o seu sobrenome: ");
        sobrenome = Console.ReadLine().Trim();
        Console.Clear();

        //validação de notas
        //n1
        try
        {
            Console.Write("Digite a 1º nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            if (n1 < 0 && n1 > 10)
            {
                Console.Write("Digite novamente a nota, valor deve estar entre 0 e 10: ");
                n1 = Convert.ToDouble(Console.ReadLine());
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nValor inválido!");
            Console.ResetColor();

            Console.Write("Digite novamente a nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
        }
        Console.Clear();

        //n2
        try
        {
            Console.Write("Digite a 2º nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            if (n2 < 0 && n2 > 10)
            {
                Console.Write("Digite novamente a nota, valor deve estar entre 0 e 10: ");
                n2 = Convert.ToDouble(Console.ReadLine());
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nValor inválido!");
            Console.ResetColor();

            Console.Write("Digite novamente a nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
        }
        Console.Clear();

        //n3
        try
        {
            Console.Write("Digite a 3º nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            if (n3 < 0 && n3 > 10)
            {
                Console.Write("Digite novamente a nota, valor deve estar entre 0 e 10: ");
                n3 = Convert.ToDouble(Console.ReadLine());
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nValor inválido!");
            Console.ResetColor();

            Console.Write("Digite novamente a nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());
        }
        Console.Clear();

        //Situação
        //aprovado >= 7
        //reprovado < 7

        mediaNotas = (n1 + n2 + n3) / 3;
        if (mediaNotas >= 7)
        {
            situacao = "Aprovado!";
        }
        else
        {
            situacao = "Reprovado";
        }

        Console.WriteLine("Aluno(a): " + nome + " " + sobrenome +
            "\nMédia: " + mediaNotas +
            "\nSituação: " + situacao);

        i++;
    }
}
//exercicio03();

static void exercicio04()
{
    //Solicitar o nome, sobrenome e apresentar o nome completo
    //Nome deve conter no máximo 15 caracteres
    //Sobrenome deve conter no mínimo 2 caracteres e no máximo 70

    string nome, sobrenome, nomeCompleto = "";

    Console.Write("Digite seu nome: ");
    nome = Console.ReadLine().Trim();
    Console.Clear();

    if (nome.Length > 15)
    {
        Console.Write("Nome atingiu o limite de caractéres, tente novamente: ");
        nome = Console.ReadLine().Trim();
        Console.Clear();
    }

    Console.Write("Digite seu sobrenome: ");
    sobrenome = Console.ReadLine().Trim();
    Console.Clear();

    if (sobrenome.Length < 2)
    {
        Console.Write("Sobrenome necessita de pelo menos 2 caractéres, tente novamente: ");
        sobrenome = Console.ReadLine().Trim();
        Console.Clear();
    }

    nomeCompleto = nome + " " + sobrenome;
    Console.WriteLine("Nome completo: " + nomeCompleto);
}
//exercicio04();

static void exercicio05()
{
    //Solicitar 10 números, apresentar a soma deles. Utilizar try catch na solicitação
    double n, acumulador = 0;
    int i = 0;

    while (i < 10)
    {
        try
        {
            Console.Write("Digite o valor " + (i + 1) + ": ");
            n = Convert.ToDouble(Console.ReadLine());
        }
        catch(FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nValor inválido!");
            Console.ResetColor();

            Console.Write("Digite novamente o valor " + (i + 1) + ": ");
            n = Convert.ToDouble(Console.ReadLine());
        }

        acumulador += n;
        i++;
    }

    Console.WriteLine("Soma total: " + acumulador);
}
//exercicio05();