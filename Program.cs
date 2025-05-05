    Console.Write("Salário por hora: ");
     double salarioHora = double.Parse(Console.ReadLine()!);

    Console.Write("Horas trabalhadas: ");
     double horas = double.Parse(Console.ReadLine()!);

    Console.Write("Horas extras: ");
     double horasExtras = double.Parse(Console.ReadLine()!);

     double salario = (salarioHora * horas) + (salarioHora * 1.4 * horasExtras);
    Console.WriteLine($"Salário final: R$ {salario:F2}");
    
