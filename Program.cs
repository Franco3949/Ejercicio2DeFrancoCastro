using System;

namespace Ejercicio2DeFrancoCastro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinacion de las variables
            float Ax, By;

            try //Control de excepciones
            {
                //Inicializacion de variables y solicitud de datos

                Console.WriteLine("Por favor ingrese el valor correspondiente a Ax:");
                Ax = float.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese el valor correspondiente a By:");
                By = float.Parse(Console.ReadLine());

                //Validacion de datos

                ValidarDatos(Ax, By);

                //Procesos por medio de funciones

                ComprobarParabola(Ax, By);

                ComprobarCircunferencia(Ax, By);

                ComprobarElipse(Ax, By);

                ComprobarHiperbola(Ax, By);


            }
            catch { Console.WriteLine("La informacion ingresada no es valida, reinicie el programa"); }
        }
        static void ComprobarParabola(float Ax, float By)
        {
            if (((Ax != 0) && (By == 0)) || ((Ax == 0) && (By != 0)))
            {
                Console.WriteLine("La conica con la que esta trabajando es una parabola");
            }
        }
        static void ComprobarCircunferencia(float Ax, float By)
        {
            if (((Ax != 0) && (By != 0)) && (Ax == By))
            {
                Console.WriteLine("La conica con la que esta trabajando es una circunferencia");
            }
        }
        static void ComprobarElipse(float Ax, float By)
        {
            if ((((Ax != 0) && (By != 0)) && (((Ax < 0) && (By < 0) || (Ax > 0) && (By > 0)))) && (Ax != By))
            {
                Console.WriteLine("La conica con la que esta trabajando es una elipse");
            }
        }
        static void ComprobarHiperbola(float Ax, float By)
        {
            if ((((Ax != 0) && (By != 0)) && (((Ax < 0) && (By > 0) || (Ax > 0) && (By < 0)))) && (Ax != By))
            {
                Console.WriteLine("La conica con la que esta trabajando es una hiperbola");
            }
        }
        static void ValidarDatos(float Ax, float By)
        {
            if ((Ax == 0) && (By == 0))
            {
                Console.WriteLine("Los datos ingresados no forman una Conica");
            }
        }
    }
}
