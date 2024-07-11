# Cafetería Web

Este proyecto es un sitio web para una cafetería que permite registrar productos (postres y bebidas) y realizar pedidos de clientes.

## Características

- Registro de productos (postres y bebidas).
- Gestión de pedidos de clientes.
- Implementación de la capa de entidades con notaciones de datos y cardinalidad.
- Clase de conexión a datos (DbContext) en la capa DAL.

## Estructura del Proyecto

El proyecto está dividido en las capas EN, DAL y BL de acuerdo a la arquitectura N-Capas:

1. **Capa de Entidades (EntidadDeNegocio):**
   - Definición de las entidades con sus propiedades y relaciones.
   - Notaciones de datos y cardinalidad.

2. **Capa de Acceso a Datos (AccesoADatos):**
   - Clase de conexión a datos (`BdContext`).

## Instalación

1. Clona el repositorio:
    ```bash
    git clone https://github.com/tu_usuario/tu_repositorio.git
    ```

2. Navega al directorio del proyecto:
    ```bash
    cd tu_repositorio
    ```

3. Restaura las dependencias del proyecto:
    ```bash
    dotnet restore
    ```

## Uso
El sistema de la cafetería web permite a los usuarios registrar productos como postres y bebidas, gestionar estos registros y realizar pedidos de clientes. Los administradores pueden agregar y actualizar los detalles de los productos, mientras que los clientes pueden navegar por el menú y hacer pedidos fácilmente. El proyecto está estructurado con una capa de entidades que define las propiedades y relaciones de los datos, y una capa de acceso a datos (DAL) que maneja la conexión a la base de datos mediante DbContext.

1. Construye el proyecto:
    ```bash
    dotnet build
    ```

2. Ejecuta la aplicación:
    ```bash
    dotnet run
    ```
    
# SysCafeteria
