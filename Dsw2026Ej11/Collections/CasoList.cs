namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

public class CasoList
{
    private List<Alumno> _alumnos = new List<Alumno>();

    public void Agregar(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public List<Alumno> GetAlumnos()
    {
        return _alumnos;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

    public void Eliminar(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void EliminarEnPosicion(int posicion)
    {
        _alumnos.RemoveAt(posicion);
    }
}
