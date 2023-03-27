internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1. Ingrese los importes de un curso");
        Console.WriteLine("2. Ver estadisticas.");
        Menu("Ingrese su respuesta (1 o 2)");
    }
    static void Menu(string msg)
    {
        int opcion;
        int promedio = 0, cantidadesTotalesCursos = 0, cantidadCursos = 0;
        string claveMP = "";
        Console.WriteLine(msg);
        opcion = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (opcion)
        {
            case 1:
                IngresarCursoYCantEst();
                break;
            case 2:
                VerEstadisticas(ref promedio, ref claveMP, ref cantidadesTotalesCursos, ref cantidadCursos);
                break;

        }

    }
    static int IngresarCursoYCantEst()
    {
        Dictionary<string, int> dicEstudiantes = new Dictionary<string, int>();
        string curso = "";
        int cantEstudiantes = -1, importe, importeTotalCurso = 0, cursoMasPlata, cantidadCursos = 0, cantidadesTotalesCursos = 0, promedio = 0;
        string claveMP;
        int cantidadAnterior = 0, mayorCantidad = 0;
                    cantEstudiantes = IngresarEntero("Ingrese la cantidad de estudiantes en el curso: ");
        for(int i = 0; i >= cantEstudiantes; i++)
        {
            curso = IngresarString("Ingrese el nombre del curso: ");
            
                for (int t = 0; t <= cantEstudiantes; t++)
                {
                    Console.WriteLine("Indique cuanto dinero va a aportar.");
                    importe = int.Parse(Console.ReadLine());
                    if (importe != 0)
                    {
                        importeTotalCurso = importeTotalCurso + importe;
                        if (importeTotalCurso > cantidadAnterior)
                        {
                            mayorCantidad = cantidadAnterior;
                            claveMP = curso;
                        }
                        cantidadesTotalesCursos = importeTotalCurso + cantidadesTotalesCursos;
                    }
                }
                dicEstudiantes.Add(curso, importeTotalCurso);
                cantidadCursos++;
        }
        Menu("Ingrese su respuesta (1 o 2)");
        promedio = cantidadesTotalesCursos / cantidadCursos;

        return importeTotalCurso;
    }

    static void VerEstadisticas(ref int promedio, ref string claveMP, ref int cantidadesTotalesCursos, ref int cantidadCursos)
    {
        Console.WriteLine($"a) El curso que más plata puso fue {claveMP}");
        Console.WriteLine($"b) El promedio de plata regalado por todos los cursos fue {promedio} ");
        Console.WriteLine($"c) La recaudación total entre todos los cursos fue {cantidadesTotalesCursos}");
        Console.WriteLine($"d) La cantidad de cursos que participaron del regalo fue {cantidadCursos}");
    }



    static string IngresarString(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }
    static int IngresarEntero(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.Parse(Console.ReadLine());
    }
}