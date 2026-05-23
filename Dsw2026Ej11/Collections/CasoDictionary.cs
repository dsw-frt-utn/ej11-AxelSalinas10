namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

    public void Agregar(Alumno alumno)
    {
        _alumnos[alumno.Id] = alumno;
    }

    public Alumno? BuscarPorLegajo(int legajo)
    {
        _alumnos.TryGetValue(legajo, out Alumno? alumno);
        return alumno;
    }

    public Dictionary<int, Alumno> GetAlumnos()
    {
        return _alumnos;
    }

    public void Eliminar(int legajo)
    {
        _alumnos.Remove(legajo);
    }
}