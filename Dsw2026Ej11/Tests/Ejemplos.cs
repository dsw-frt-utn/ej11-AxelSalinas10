namespace Dsw2026Ej11.Tests;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList lista = new CasoList();
        lista.Agregar(new Alumno(58318, "Axel Salinas", 8.5));
        lista.Agregar(new Alumno(58319, "Lucas Romero", 7.2));
        lista.Agregar(new Alumno(58320, "Valentina Torres", 9.1));
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var a in lista.GetAlumnos())
            Console.WriteLine(a);
        Console.WriteLine("\n=== Buscar 'Lucas Romero' ===");
        var encontrado = lista.BuscarPorNombre("Lucas Romero");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Buscar 'Pedro Ruiz' ===");
        var noEncontrado = lista.BuscarPorNombre("Pedro Ruiz");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Eliminar 'Lucas Romero' ===");
        lista.Eliminar(encontrado!);
        foreach (var a in lista.GetAlumnos())
            Console.WriteLine(a);
        Console.WriteLine("\n=== Eliminar primer elemento ===");
        lista.EliminarEnPosicion(0);
        foreach (var a in lista.GetAlumnos())
            Console.WriteLine(a);
    }
    public static void EjemploDictionary()
    {
        CasoDictionary dic = new CasoDictionary();
        dic.Agregar(new Alumno(58318, "Axel Salinas", 8.5));
        dic.Agregar(new Alumno(58319, "Lucas Romero", 7.2));
        dic.Agregar(new Alumno(58320, "Valentina Torres", 9.1));
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in dic.GetAlumnos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
        Console.WriteLine("\n=== Buscar legajo 58319 ===");
        var encontrado = dic.BuscarPorLegajo(58319);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Buscar legajo 99999 ===");
        var noEncontrado = dic.BuscarPorLegajo(99999);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");
        Console.WriteLine("\n=== Eliminar legajo 58318 ===");
        dic.Eliminar(58318);
        foreach (var par in dic.GetAlumnos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
    }
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();
        Console.WriteLine($"Primero: {linq.GetPrimero().Titulo}");
        Console.WriteLine($"Último: {linq.GetUltimo().Titulo}");
        Console.WriteLine($"Total precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio precios: {linq.GetPromedioPrecios():C}");
        Console.WriteLine("\n=== Libros con Id > 15 ===");
        linq.GetListById().ForEach(l => Console.WriteLine(l.Titulo));
        Console.WriteLine("\n=== Título y precio ===");
        linq.GetLibros().ForEach(Console.WriteLine);
        Console.WriteLine($"\nMayor precio: {linq.GetMayorPrecio().Titulo}");
        Console.WriteLine($"Menor precio: {linq.GetMenorPrecio().Titulo}");
        Console.WriteLine("\n=== Libros sobre el promedio ===");
        linq.GetMayorPromedio().ForEach(l => Console.WriteLine(l.Titulo));
        Console.WriteLine("\n=== Ordenados por título descendente ===");
        linq.GetOrdenadosPorTituloDesc().ForEach(l => Console.WriteLine(l.Titulo));
    }
}