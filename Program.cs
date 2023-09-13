
Console.WriteLine("Programa para calcular seu IMC e descobrir sua faixa etária");
do{
    string faixa = ("");
    Console.WriteLine("Por favor, informe seu nome abaixo");
    string? nome = Console.ReadLine(); //Variável para o nome da pessoa
    Console.WriteLine("Agora informe sua idade"); 
    double idade = Convert.ToDouble(Console.ReadLine()); //Variável para armazenar a idade
    Console.WriteLine("Informe sua altura");
    double altura = Convert.ToDouble(Console.ReadLine()); //Variável para armazenar a altura
    Console.WriteLine("Por último, informe seu peso");
    double peso = Convert.ToDouble(Console.ReadLine()); // Variável para armazenar o peso
    double IMC = peso / (altura * altura);
    if(idade <= 12) //Seleção da faixa etária
    {
        faixa += ("Criança");
    }
    else if(idade >= 13 && idade <= 18)
    {
        faixa = ("Adolescente");
    }
    else if(idade >= 19 && idade <= 59)
    {
        faixa = ("Adulto(a)");
    }
    else
    {
        faixa = ("Idoso(a)");
    }
    if(IMC <= 18.5 && IMC <= 18.99) //Seleção do IMC e informando o relatório
    {
    Console.WriteLine($"Olá {nome}");
    Console.WriteLine("Você tem " + idade + $" anos e é um(a) {faixa}");
    Console.WriteLine($"Seu IMC é {IMC} e você está abaixo do peso ideal");
    }
    else if(IMC >= 18.6 && IMC <= 24.9)
    {
        Console.WriteLine($"Olá {nome}");
        Console.WriteLine("Você tem " + idade + $" anos e é um(a) {faixa}");
        Console.WriteLine($"Seu IMC é {IMC} e você está no peso ideal");
    }
    else if(IMC >= 25 && IMC <= 29.9)
    {
        Console.WriteLine($"Olá {nome}");
        Console.WriteLine("Você tem" + idade + $" anos e é um(a) {faixa}");
        Console.WriteLine($"Seu IMC é {IMC} e você está levemente acima do peso");
    }
    else if(IMC >= 30 && IMC <= 34.9)
    {
        Console.WriteLine($"Olá {nome}");
        Console.WriteLine("Você tem " + idade + $" anos e é um(a) {faixa}");
        Console.WriteLine($"Seu IMC é {IMC} e você está com obesidade grau 1");
    }
    else if(IMC >= 35 && IMC <= 39.9)
    {
        Console.WriteLine($"Olá {nome}");
        Console.WriteLine("Você tem " + idade + $" anos e é um(a) {faixa}");
        Console.WriteLine($"Seu IMC é {IMC} e você está com obesidade grau 2");
    }
    else
    {
        Console.WriteLine($"Olá {nome}");
        Console.WriteLine("Você tem " + idade + $" anos e é um(a) {faixa}");
        Console.WriteLine($"Seu IMC é {IMC} e você está com obesidade grau 3");
    }
    Console.WriteLine("Deseja fazer o relatório novamente S/N?");
    string? resposta = Console.ReadLine();
    if(resposta == "S" | resposta == "s" | resposta == "sim" | resposta == "Sim") //Concluindo e perguntando se o usuário deseja continuar
    {
    continue;
    }
    else{
    break;
    }
}while(true);