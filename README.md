# Proyecto ProductosAPI

Este es un proyecto de ejemplo para gestionar productos con una API REST construida en .NET 8.0 y SQLite como base de datos.

## Requisitos

- **.NET 8.0 SDK**: Asegúrate de tener la versión más reciente de .NET SDK instalada.
- **SQLite**: La base de datos se configura para usar SQLite.

## Configuración de SQLite

1. Configura la base de datos de SQLite:
   En el archivo `appsettings.json` del proyecto, asegúrate de que la cadena de conexión apunte a un archivo SQLite local, por ejemplo:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Data Source=ProductosAPI.db"
   }

Ejecutar Migraciones
  1. Abre una terminal en la carpeta del proyecto.
  2. Ejecuta el siguiente comando para aplicar las migraciones y crear la base de datos:
     Add-Migration InitialCreate
     Update-Database
