namespace EjemploInterfaces;
public class Silla : IMueble
{
    public Silla(string color, int cantidadPatas)
    {
        this.color = color;
        this.cantidadPatas = cantidadPatas;
    }

    public string color { get; set; }

    public int cantidadPatas { get; set; }

    public void Arreglar()
    {
        throw new NotImplementedException();
    }

    public void Pintar(string nuevoColor)
    {
        this.color = nuevoColor;
        System.Console.WriteLine(this.color);
    }
}