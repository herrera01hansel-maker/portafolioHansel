# Portafolio personal de Hansel Steven Herrera Serrano

Portafolio personal desarrollado con **ASP.NET Core MVC (.NET 8)** y publicado en **Azure App Service**
mediante un pipeline de **CI/CD en Azure DevOps**. Presenta el perfil académico del autor (Ingeniería en
Sistemas, inteligencia de negocios y datos), sus habilidades, sus proyectos y el proceso de despliegue.

Actividad: Entrega de Portafolio CI/CD. Optativa I, Aplicaciones en la Nube. UNAN-Managua, CUR-Carazo.

## Enlaces

| Recurso | Enlace |
|---|---|
| Repositorio en GitHub | `PENDIENTE: https://github.com/TU_USUARIO/PortafolioHansel` |
| Sitio publicado | `PENDIENTE: https://NOMBRE-DE-TU-APP.azurewebsites.net` |
| Proyecto en Azure DevOps | `PENDIENTE: https://dev.azure.com/TU_ORGANIZACION/PortafolioHansel` |

## Tecnologías utilizadas

- C# y ASP.NET Core MVC sobre .NET 8
- Razor (vistas), HTML5 y CSS3 sin frameworks externos
- Git y GitHub para el control de versiones
- Azure DevOps (Azure Pipelines) para la integración y la entrega continuas
- Azure App Service para el alojamiento

## Requisitos previos

- [SDK de .NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) (compatible con versiones posteriores del SDK)
- Visual Studio 2022 o posterior, o Visual Studio Code
- Git

Comprueba tu instalación con:

```bash
dotnet --list-sdks
git --version
```

## Ejecutar localmente

```bash
dotnet restore
dotnet build
dotnet run
```

Abre la dirección que muestra la terminal (por defecto `http://localhost:5080`).
En Visual Studio selecciona el perfil **http** o **https** junto al botón de inicio y pulsa **Ctrl+F5**.

## Estructura del proyecto

```text
PortafolioHansel/
├── Controllers/
│   └── HomeController.cs        Controlador: entrega el perfil a la vista
├── Models/
│   ├── PerfilPortafolio.cs      Clases del modelo (perfil, habilidades, proyectos, pasos)
│   ├── DatosPortafolio.cs       Contenido del portafolio (textos, proyectos, contacto)
│   └── ErrorViewModel.cs
├── Views/
│   ├── Home/Index.cshtml        Página principal con todas las secciones
│   ├── Shared/_Layout.cshtml    Estructura común (cabecera, menú, pie)
│   └── Shared/Error.cshtml
├── wwwroot/
│   ├── css/site.css             Estilos del sitio
│   └── img/                     Fotografía y capturas del sistema de inventario
├── Program.cs                   Configuración y arranque de la aplicación
├── azure-pipelines.yml          Definición del pipeline CI/CD
└── PortafolioHansel.csproj
```

## Personalizar el contenido

Todo el texto, los proyectos y los datos de contacto están en `Models/DatosPortafolio.cs`.
Completa `Correo`, `GitHub` y `LinkedIn`; si un valor queda vacío, su enlace no se muestra.

## Pipeline CI/CD

El archivo `azure-pipelines.yml` define dos etapas que se ejecutan en cada `push` a la rama `main`:

1. **Build (integración continua):** instala el SDK de .NET 8, restaura las dependencias, compila en
   configuración Release, publica la aplicación en un paquete `.zip` y lo guarda como artefacto `drop`.
2. **Deploy (entrega continua):** toma el artefacto `drop` y lo despliega en Azure App Service con la
   tarea `AzureWebApp@1`, usando una conexión de servicio de Azure.

Valores que deben coincidir con tus recursos reales (variables al inicio del archivo):

| Variable | Qué poner |
|---|---|
| `azureSubscription` | Nombre de la Service Connection creada en Azure DevOps |
| `webAppName` | Nombre exacto del App Service creado en Azure |

## Instrucciones de publicación

1. Subir el código a GitHub (repositorio público, rama `main`).
2. Crear la organización y el proyecto en Azure DevOps.
3. Crear el App Service en Azure (runtime .NET 8).
4. Crear la Service Connection de tipo Azure Resource Manager en Azure DevOps.
5. Crear el pipeline desde el repositorio de GitHub usando el archivo `azure-pipelines.yml` existente.
6. Autorizar la primera ejecución y verificar el sitio en la URL del App Service.

A partir de ahí, cada `git push` a `main` actualiza el sitio automáticamente.

## Autor

Hansel Steven Herrera Serrano. Ingeniería en Sistemas, UNAN-Managua, CUR-Carazo.
