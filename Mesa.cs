namespace EjemploInterfaces;
public class Mesa : IMueble, IPersona
{
    private string v1;
    private int v2;

    public Mesa(string v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public string color { get; set; }

    public int cantidadPatas { get; set; }

    public void Arreglar()
    {
        throw new NotImplementedException();
    }

    public void Mover()
    {
        throw new NotImplementedException();
    }

    public void Pintar(string nuevoColor)
    {
        throw new NotImplementedException();
    }
}