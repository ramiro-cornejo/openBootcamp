using System;


namespace OpenBootcamp
{
    internal class Program
    {
        /*
        // Ejercicio de objetos numero 2
        // obj coche
        int puertas = 5;
        int ruedas = 4;
        string marca = "Ford";
        string itv = "Vigente";

        // obj mesa peso, largo, material, color
        int peso = 8;
        int largo = 3;
        string material = "Madera";
        string color = "Blanca";
        */

        static void Main(string[] args)
        {
            /*
            // EJERCICIO 1
            // Recibir nombre y escribir en consola
            Console.WriteLine("Introduce tu nombre: ");

            string nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre);
            */

            /*
            // EJERCICIO 2
            // Introducir tu edad por consola
            // presentar mensaje
            Console.WriteLine("Introduce tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hola, mi edad es: " + edad);
            */

            /*
            // EJERCICIO 3
            // Tomar la hora y escribirla por consola
            Console.WriteLine("¿Que hora es?");

            string hora = Console.ReadLine();
            Console.WriteLine("La hora es: " + hora);
            */

            // TIPOS DE DATOS Y VARIABLES
            /*
            int i = 0;
            long l = 1;

            float f = 1.55555f;
            double d = 2.6666666666d;

            char c = 'c';
            string str = "string";

            Console.Write("int: " + i);
            Console.WriteLine(" long: " + l);

            Console.Write("float: " + f);
            Console.WriteLine(" double: " + d);

            Console.Write("char: " + c);
            Console.WriteLine(" string: " + str);
            

            string str2 = "35";
            int miInt2 = Convert.ToInt32(str2);

            Console.Write("str2: " + str2);
            miInt2 = miInt2 + 1;
            Console.WriteLine(" miInt2: " + miInt2);

            // Ejemplo para const
            const float pi = 3.1415f; // constante matematica
            // codigo
            float cualquierFloat = pi * 2;

            */

            // EJEMPLO - NULL (no hay nada pero no es vacio)
            //int? i = null;

            //Console.WriteLine(i.HasValue); // metodo para mostrar false/true
            //Console.WriteLine(i + 1); // no mostrara nada en consola


            // OPERADORES

            // ARITMETICOS + - * / % ++ --

            //int i = 4;
            //Console.WriteLine("Suma: " + (i + 1));

            /*
            Console.WriteLine("Autoincremento: " + ++i); // ++i suma uno
            Console.WriteLine("Autodecremento: " + --i); // --i resta uno
            Console.WriteLine("Valor: " + i);
            */

            //Console.WriteLine("Division: " + i);
            //Console.WriteLine("Division: " + i / 4);

            // ASIGNACION = += -= *= /= %= &= |= ^=  >>= <<=

            /*
            int j = 1;

            Console.WriteLine("Sumo 3: " + (j += 3));
            Console.WriteLine("j: " + j);
            */

            // COMPARACION == != > < >= <=

            /*
            int j = 1;
            int k = 2;

            Console.WriteLine("Iguales? " + (j == k));
            Console.WriteLine("j mayor? " + (j > k));
            Console.WriteLine("j menor? " + (j < k));
            */

            /*
            // LOGICOS && || !

            int a = 9;
            int b = 11;

            // Y - AND
            
            Console.WriteLine("True true: " + (a<10 && b>10));
            Console.WriteLine("False true: " + (a > 10 && b > 10));
            Console.WriteLine("True false: " + (a < 10 && b < 10));
            Console.WriteLine("False false: " + (a > 10 && b < 10));
            
            // O - OR

            Console.WriteLine("True true: " + (a < 10 || b > 10));
            Console.WriteLine("False true: " + (a > 10 || b > 10));
            Console.WriteLine("True false: " + (a < 10 || b < 10));
            Console.WriteLine("False false: " + (a > 10 || b < 10));

            // NO - NOT 

            Console.WriteLine("True: " + !(a < 10));
            Console.WriteLine("False: " + !(a > 10));
            */


            //EJERCICIO 1

            //Variables Escribe un programa que reciba datos de una persona y genera un mensaje, 
            //usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.

            /*
            Console.WriteLine("Ejercicio 1 Variables");

            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Introduce tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce tus estudios: ");
            string estudios = Console.ReadLine();


            Console.WriteLine("Hola,mi nombre es: " + nombre + " " + apellido + "." + "Tengo" + " " + edad + " " + "años." + "Estudio: " + estudios);


            //EJERCICIO 2

            //Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
            //-Coche: puertas, ruedas, marca, ITV vigente
            //-Mesa: peso, largo, material, color
            //Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.

            Console.WriteLine("Ejercicio 2 Objetos");

            // Objeto utilizando program para el ejemplo Coche/Mesa
            Program myObj = new Program();
            Console.WriteLine(myObj.puertas);
            Console.WriteLine(myObj.ruedas);
            Console.WriteLine(myObj.marca);
            Console.WriteLine(myObj.itv);

            Program myObj2 = new Program();
            Console.WriteLine(myObj2.peso);
            Console.WriteLine(myObj2.largo);
            Console.WriteLine(myObj2.material);
            Console.WriteLine(myObj2.color);

            //EJERCICIO 3

            //Operadores Determina los operadores para verificar las siguientes condiciones:
            //Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es almacenar los datos en los tipos más adecuados.
            
            Console.WriteLine("Ejercicio 3 Operadores");

            //-Un número es mayor o igual a 18
            int numero1 = 5;
            int numero2 = 10;

            Console.WriteLine("El numero es mayor o igual a 18? " + (numero1 >= numero2));

            //-Un char es ‘a’
            char a = 'a';
            Console.Write("char: " + a);

            //-Se cumplen dos condiciones a la vez (ambas verdaderas)
            Console.WriteLine(" True true: " + (numero1 < 15 && numero2 < 15));

            //-Se cumple una de dos condiciones a la vez (una true y otra false)
            Console.WriteLine(" True false: " + (numero1 < 15 && numero2 > 15));
            Console.WriteLine("True false: " + (numero1 < 9 && numero2 < 9));
            */

        }
    }
}


