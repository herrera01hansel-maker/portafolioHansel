namespace PortafolioHansel.Models;

/// <summary>
/// Todo el contenido del portafolio vive aquí.
/// Para cambiar textos, proyectos o enlaces solo edita este archivo.
/// </summary>
public static class DatosPortafolio
{
    public static PerfilPortafolio Obtener()
    {
        var perfil = new PerfilPortafolio();

        perfil.Nombre = "Hansel Steven Herrera Serrano";

        perfil.Resumen =
            "Estudiante de Ingeniería en Sistemas. Me enfoco en inteligencia de negocios: " +
            "modelo datos, construyo procesos ETL y armo reportes para decidir mejor. " +
            "También desarrollo sistemas web con ASP.NET Core.";

        perfil.SobreMi = new string[]
        {
            "Estudio Ingeniería en Sistemas en la UNAN-Managua, CUR-Carazo, y estoy construyendo mi camino " +
            "en inteligencia de negocios y datos. Me interesa el trabajo que ocurre antes del gráfico: " +
            "entender cómo opera un negocio, ordenar su información en un modelo dimensional y comprobar " +
            "que los números cuadren.",

            "Aprendo haciendo proyectos completos. Trabajé en un data warehouse con ETL y cubos OLAP sobre " +
            "la base de datos de una ferretería, y desarrollo sistemas web para negocios pequeños donde las " +
            "ventas, las compras y el inventario se registran y se convierten en reportes."
        };

        perfil.Datos = new List<Dato>
        {
            new Dato("Formación", "Ingeniería en Sistemas, UNAN-Managua CUR-Carazo"),
            new Dato("Enfoque", "Inteligencia de negocios y datos"),
            new Dato("También", "Desarrollo web con ASP.NET Core MVC"),
            new Dato("Busco", "Un puesto junior en BI o datos")
        };

        perfil.Habilidades = new List<GrupoHabilidades>
        {
            new GrupoHabilidades("Datos e inteligencia de negocios", new string[]
            {
                "SQL Server", "Power Query", "Modelo dimensional", "ETL", "Cubos OLAP", "KPIs y reportes"
            }),
            new GrupoHabilidades("Desarrollo web", new string[]
            {
                "C#", "ASP.NET Core MVC", "HTML y CSS", "TypeScript", "React", "Node.js", "PostgreSQL"
            }),
            new GrupoHabilidades("Herramientas y nube", new string[]
            {
                "Git y GitHub", "Azure DevOps", "Azure App Service", "Pipelines CI/CD con YAML"
            })
        };

        perfil.Proyectos = new List<Proyecto>
        {
            new Proyecto(
                "Data warehouse de la ferretería",
                "Proyecto universitario",
                "Modelo dimensional, procesos ETL y cubos OLAP construidos sobre la base de datos " +
                "Mini_FerreteriaDT, con indicadores para analizar las ventas del negocio.",
                new string[] { "SQL Server", "ETL", "OLAP" }),

            new Proyecto(
                "ReparaControl",
                "Proyecto personal",
                "Sistema web para talleres de reparación en Nicaragua: clientes, equipos, órdenes de " +
                "reparación, cotizaciones, pagos y reportes.",
                new string[] { "React", "TypeScript", "Node.js", "PostgreSQL" }),

            new Proyecto(
                "TechTrove, sistema para tienda de accesorios",
                "Proyecto para un negocio",
                "Sistema web para una tienda de accesorios de celulares: productos, ventas, compras, " +
                "pedidos con delivery, gastos y cálculo de la utilidad neta.",
                new string[] { "React", "Node.js", "Prisma", "PostgreSQL" })
        };

        perfil.Despliegue = new List<PasoDespliegue>
        {
            new PasoDespliegue("Subo el código", "Hago git push a la rama main del repositorio en GitHub."),
            new PasoDespliegue("Azure Pipelines compila", "El pipeline restaura paquetes, compila en Release y publica el sitio."),
            new PasoDespliegue("Se despliega", "El paquete se envía a Azure App Service sin pasos manuales."),
            new PasoDespliegue("El sitio se actualiza", "La nueva versión queda en línea pocos minutos después del push.")
        };

        // PENDIENTE: completa estos tres valores antes de publicar.
        perfil.Correo = "";
        perfil.GitHub = "";     // Ejemplo: "https://github.com/tu-usuario"
        perfil.LinkedIn = "";   // Ejemplo: "https://www.linkedin.com/in/tu-usuario"

        return perfil;
    }
}
