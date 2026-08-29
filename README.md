# Empresa Comercializadora de Seguros

Aplicación de escritorio en C# (WinForms) para la gestión de una comercializadora de seguros: administración de clientes, aseguradoras, pólizas, pagos, usuarios del sistema y generación de certificados en PDF, con persistencia en SQL Server.

## Características

- Inicio de sesión con pantalla de bienvenida (Splash).
- Gestión de clientes.
- Gestión de aseguradoras y pólizas.
- Gestión de pagos.
- Generación de certificados de póliza en PDF (iTextSharp).
- Informes y estadísticas.
- Administración de usuarios del sistema.

## Tecnologías

- **Lenguaje:** C#
- **Interfaz gráfica:** Windows Forms (.NET Framework 4.7.2)
- **Base de datos:** SQL Server (ADO.NET / `SqlConnection`, autenticación integrada de Windows)
- **Librerías (NuGet):**
  - `Guna.UI2.WinForms` — componentes de interfaz modernos
  - `iTextSharp` — generación de PDFs (certificados de póliza)
  - `BouncyCastle` — criptografía (dependencia de iTextSharp)

## Estructura del proyecto

```
Empresa Comercializadora/
├── Empresa_Comercializadora.sln          # Solución de Visual Studio
├── packages/                              # Librerías NuGet (se restauran automáticamente)
└── Empresa Comercializadora/              # Proyecto
    ├── App.config                          # Cadena de conexión a SQL Server
    ├── Program.cs                          # Punto de entrada
    ├── Formularios/                        # Pantallas (Login, Clientes, Pagos, Pólizas, Seguros, Informes, Usuarios)
    ├── Modelo/                              # Entidades (Cliente, Poliza, Seguro, Pago, Usuario, Aseguradora)
    ├── Repositorio/                        # Acceso a datos (ADO.NET)
    ├── Imagenes/                            # Recursos gráficos
    └── Certificados/                       # PDFs de pólizas generados en tiempo de ejecución
```

## Requisitos previos

- Visual Studio 2019/2022 (o compatible con .NET Framework 4.7.2)
- SQL Server (Express o superior)

## Configuración

1. Crea la base de datos `ComercializadoraSeguros` en tu instancia de SQL Server (importa el script SQL correspondiente, si lo tienes).
2. Abre `Empresa Comercializadora/App.config` y ajusta la cadena de conexión `Conexion` con el nombre de tu instancia de SQL Server:

```xml
<connectionStrings>
  <add name="Conexion"
       connectionString="Data Source=TU_SERVIDOR\SQLEXPRESS;Initial Catalog=ComercializadoraSeguros;Integrated Security=True"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

## Ejecución

1. Abre `Empresa_Comercializadora.sln` en Visual Studio.
2. Espera a que se restauren automáticamente los paquetes NuGet (`packages.config`).
3. Compila y ejecuta el proyecto (F5).

## Licencia

Proyecto académico/personal.
