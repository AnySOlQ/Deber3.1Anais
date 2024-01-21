using System;

class Vehiculo
{
    private string marca;
    private string modelo;
    private int año;

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int Año
    {
        get { return año; }
        set { año = value; }
    }

    public virtual void getInformation()  // Marcar como 'virtual'
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Año: {año}");
    }

    public virtual void runAction()
    {
        Console.WriteLine("Realizando acción genérica del vehículo");
    }
}

class Automovil : Vehiculo
{
    private int puertas;

    public int Puertas
    {
        get { return puertas; }
        set { puertas = value; }
    }

    public override void getInformation()  // Marcar como 'override'
    {
        base.getInformation();
        Console.WriteLine($"Puertas: {puertas}");
    }

    public override void runAction()
    {
        Console.WriteLine("Conduciendo automóvil");
    }
}

class Camioneta : Vehiculo
{
    private double capacidadCarga;

    public double CapacidadCarga
    {
        get { return capacidadCarga; }
        set { capacidadCarga = value; }
    }

    public override void getInformation()  // Marcar como 'override'
    {
        base.getInformation();
        Console.WriteLine($"Capacidad de carga: {capacidadCarga} toneladas");
    }

    public override void runAction()
    {
        Console.WriteLine("Cargando camioneta");
    }
}

class Program
{
    static void Main()
    {
        Automovil miAutomovil = new Automovil();
        miAutomovil.Marca = "Toyota";
        miAutomovil.Modelo = "Corolla";
        miAutomovil.Año = 2022;
        miAutomovil.Puertas = 4;

        Camioneta miCamioneta = new Camioneta();
        miCamioneta.Marca = "Ford";
        miCamioneta.Modelo = "F-150";
        miCamioneta.Año = 2021;
        miCamioneta.CapacidadCarga = 2.5;

        Console.WriteLine("Información del Automóvil:");
        miAutomovil.getInformation();
        miAutomovil.runAction();

        Console.WriteLine("\nInformación de la Camioneta:");
        miCamioneta.getInformation();
        miCamioneta.runAction();
    }
}

