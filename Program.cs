using System;

Console.WriteLine("EVALUACIÓN DE BOMBAS ELÉCTRICAS");
Console.WriteLine();

// Crear objetos para la Bomba 1 y Bomba 2
BombaElectrica bomba1 = new BombaElectrica();
Console.WriteLine("--- DATOS DE LA BOMBA 1 ---");
Console.Write("Ingrese el identificador: ");
bomba1.Identificador = Console.ReadLine() ?? "Bomba 1";
Console.Write("Ingrese el voltaje (V): ");
bomba1.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente (A): ");
bomba1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el caudal (L/min): ");
bomba1.Caudal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
BombaElectrica bomba2 = new BombaElectrica();
Console.WriteLine("--- DATOS DE LA BOMBA 2 ---");
Console.Write("Ingrese el identificador: ");
bomba2.Identificador = Console.ReadLine() ?? "Bomba 2";
Console.Write("Ingrese el voltaje (V): ");
bomba2.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente (A): ");
bomba2.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el caudal (L/min): ");
bomba2.Caudal = Convert.ToDouble(Console.ReadLine());

// Comparar y mostrar resultados
Console.WriteLine();
Console.WriteLine("--- RESULTADOS Y COMPARACIÓN ---");
bomba1.MostrarInformacion();
bomba2.MostrarInformacion();

Console.WriteLine();
double ind1 = bomba1.CalcularIndicadorDesempeno();
double ind2 = bomba2.CalcularIndicadorDesempeno();

if (ind1 > ind2)
{
    Console.WriteLine($"Conclusión: La bomba '{bomba1.Identificador}' entrega más caudal por vatio.");
}
else if (ind2 > ind1)
{
    Console.WriteLine($"Conclusión: La bomba '{bomba2.Identificador}' entrega más caudal por vatio.");
}
else
{
    Console.WriteLine("Conclusión: Existe un empate en el desempeño de ambas bombas.");
}

// Definición de la clase BombaElectrica
class BombaElectrica
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double Voltaje { get; set; }
    public double Corriente { get; set; }
    public double Caudal { get; set; }

    // Calcular Potencia P = V * I
    public double CalcularPotencia()
    {
        return Voltaje * Corriente;
    }

    // Calcular Indicador de Desempeño (Caudal / Potencia)
    public double CalcularIndicadorDesempeno()
    {
        double potencia = CalcularPotencia();
        if (potencia == 0) return 0;
        return Caudal / potencia;
    }

    // Mostrar información de la bomba
    public void MostrarInformacion()
    {
        double potencia = CalcularPotencia();
        double indicador = CalcularIndicadorDesempeno();
        Console.WriteLine($"Bomba: {Identificador} | Potencia: {potencia:F2} W | Indicador: {indicador:F4} (L/min)/W");
    }
}