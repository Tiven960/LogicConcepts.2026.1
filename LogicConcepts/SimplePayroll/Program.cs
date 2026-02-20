// See https://aka.ms/new-console-template for more information

using Shared;

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese numero de horas trabajadas:");
    var hoursValue = ConsoleExtension.GetDecimal("Ingrese valor hora:");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese salario minimo mensual:");

    var salary = (decimal)workHours * hoursValue;
    if(salary < salaryMinimun)
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario: {salaryMinimun:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"alario: {salary:C2}");
    }

} while (true);

