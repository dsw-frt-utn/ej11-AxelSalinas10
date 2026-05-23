namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

public class CasoLinq
{
    private List<Libro> _libros = Libro.CrearLista();

    public Libro GetPrimero() =>
        _libros.First();

    public Libro GetUltimo() =>
        _libros.Last();

    public decimal GetTotalPrecios() =>
        _libros.Sum(l => l.Precio);

    public decimal GetPromedioPrecios() =>
        _libros.Average(l => l.Precio);

    public List<Libro> GetListById() =>
        _libros.Where(l => l.Id > 15).ToList();

    public List<string> GetLibros() =>
        _libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();

    public Libro GetMayorPrecio() =>
        _libros.MaxBy(l => l.Precio)!;

    public Libro GetMenorPrecio() =>
        _libros.MinBy(l => l.Precio)!;

    public List<Libro> GetMayorPromedio()
    {
        decimal promedio = GetPromedioPrecios();
        return _libros.Where(l => l.Precio > promedio).ToList();
    }

    public List<Libro> GetOrdenadosPorTituloDesc() =>
        _libros.OrderByDescending(l => l.Titulo).ToList();
}
