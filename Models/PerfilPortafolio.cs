namespace PortafolioHansel.Models;

public record Dato(string Etiqueta, string Valor);

public record GrupoHabilidades(string Titulo, string[] Items);

public record Proyecto(string Nombre, string Estado, string Descripcion, string[] Tecnologias);

public record PasoDespliegue(string Titulo, string Detalle);

public class PerfilPortafolio
{
    public string Nombre { get; set; } = string.Empty;
    public string Resumen { get; set; } = string.Empty;
    public string[] SobreMi { get; set; } = Array.Empty<string>();
    public List<Dato> Datos { get; set; } = new List<Dato>();
    public List<GrupoHabilidades> Habilidades { get; set; } = new List<GrupoHabilidades>();
    public List<Proyecto> Proyectos { get; set; } = new List<Proyecto>();
    public List<PasoDespliegue> Despliegue { get; set; } = new List<PasoDespliegue>();

    // Contacto: si un valor queda vacío, el enlace no se muestra en el sitio.
    public string Correo { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
}
