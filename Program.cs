double CalcularSalario(double salarioHoraBase, double horasTrabalhadas, double horasExtras)
{
    double salarioNormal = salarioHoraBase * horasTrabalhadas;
    double salarioExtra = horasExtras * (salarioHoraBase * 1.40);
    return salarioNormal + salarioExtra;
} 
    Console.WriteLine("--- Calculadora de Salário ---");

    Console.Write("Salário-hora base (R$): ");
    double salarioHora = double.Parse(Console.ReadLine()!);

    Console.Write("Total de horas trabalhadas: ");
    double horasTrabalhadas = double.Parse(Console.ReadLine()!);

    Console.Write("Número de horas extras: ");
    double horasExtras = double.Parse(Console.ReadLine()!);

    double salarioFinal = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);

    Console.WriteLine($"\nSalário total: R$ {salarioFinal:F2}"); 
    





