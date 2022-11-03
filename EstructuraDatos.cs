// ¿QUE SON LAS ESTRUCTURAS DE DATOS?
/*
    -Datos del mismo tipo se pueden agrupar en colecciones
    -Podemos usar metodos de colecciones para realizar operaciones de formas simple
    -Evitamos errores y ahorramos tiempo
 */

// Struc : Datos con una utilidad
// Ref : Cuando se necesite un objeto de tipo referencia
// Readonly : Proteccion ante escritura, solo lectura

// creando objeto ejemplo 1
/*
Coords misCoordenadas = new Coords(2, 10, 5);
Console.WriteLine("X: " + misCoordenadas.X);
Console.WriteLine("Y: " + misCoordenadas.Y);
Console.WriteLine("R: " + misCoordenadas.R);

Coords misCoordenadas2 = misCoordenadas with { X = 3 };
Console.WriteLine(misCoordenadas2);

public struct Coords
{

    public Coords(double x, double y, double r)
    {
        X = x;
        Y = y;
        R = r;

    }

    public double X { get; set; }
    public double Y { get; set; }

    public double R { get; set; }

    public override string ToString() => $"({X}, {Y}, {R})";
         
}*/

/*
    // Ejercicio 1

    //Crea una estructura de datos para un cliente con estos campos:
    //Nombre completo
    //Teléfono
    //Dirección
    //Email
    //Si es nuevo cliente

    //Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 */



Cliente misDatos = new Cliente();


Console.WriteLine("Nombre: " + misDatos.Nombre);
Console.WriteLine("Telefono: " + misDatos.Telefono);
Console.WriteLine("Dirección: " + misDatos.Direccion);


public struct Cliente
{

    public Cliente(double nombre, double telefono, double direccion)
    {
        this.Nombre = nombre;
        this.Telefono = telefono;
        this.Direccion = direccion;

    }

    public double Nombre { get; set; }
    public double Telefono { get; set; }

    public double Direccion { get; set; }

    public override string ToString() => $"({Nombre}, {Telefono}, {Direccion})";

}
