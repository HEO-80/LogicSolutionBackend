# LogicSolutions Backend 🚚⚙️

[ES]
**LogicSolutions Backend** es una API REST robusta desarrollada en **.NET 5.0 (C#)** que sirve como el núcleo lógico para una plataforma de gestión logística. Este servicio gestiona la persistencia de datos, la lógica de negocio para la contratación de transportes y proporciona los endpoints necesarios para el seguimiento de operativas.

[EN]
**LogicSolutions Backend** is a robust REST API developed in **.NET 5.0 (C#)** that serves as the logical core for a logistics management platform. This service handles data persistence, business logic for transport hiring, and provides the necessary endpoints for operations tracking.

---

## ✨ Características Principales | Key Features

### [ES]
* **Arquitectura en Capas:** Separación clara de responsabilidades utilizando Controladores, Servicios e Interfaces.
* **Patrón DTO:** Uso de Data Transfer Objects (`/Dtos`) para optimizar y asegurar el intercambio de información.
* **Entity Framework Core:** Mapeo objeto-relacional (ORM) con migraciones (`/Migrations`) para la gestión de la base de datos.
* **API RESTful:** Endpoints estructurados para la integración fluida con el frontend de la plataforma.

### [EN]
* **Layered Architecture:** Clear separation of concerns using Controllers, Services, and Interfaces.
* **DTO Pattern:** Use of Data Transfer Objects (`/Dtos`) to optimize and secure data exchange.
* **Entity Framework Core:** Object-Relational Mapping (ORM) with migrations (`/Migrations`) for database management.
* **RESTful API:** Structured endpoints for seamless integration with the platform's frontend.

---

## 🛠️ Tecnologías Utilizadas | Tech Stack
* **Framework:** .NET 5.0 (ASP.NET Core)
* **Language:** C#
* **ORM:** Entity Framework Core
* **Architecture:** REST, Layered (Controllers / Services / Data / Models)

---

## 🏗️ Estructura del Proyecto | Project Structure
* `/Controllers`: Puntos de entrada de la API que manejan las peticiones HTTP.
* `/Services` & `/Interfaces`: Lógica de negocio encapsulada e interfaces para inyección de dependencias.
* `/Models`: Entidades de dominio que representan las tablas de la base de datos (vehículos, envíos, etc.).
* `/Data`: Contexto de base de datos de Entity Framework.
* `/Dtos`: Objetos de transferencia de datos para formatear respuestas y peticiones.

---

## 🚀 Despliegue Local | Local Setup

### Prerrequisitos / Prerequisites
* .NET 5.0 SDK instalado.
* Motor de base de datos compatible (ej. SQL Server) configurado en `appsettings.json`.

### Instalación / Installation
1. Clonar el repositorio:

    git clone https://github.com/HEO-80/LogicSolutionBackend.git

2. Entrar en el directorio del proyecto:

    cd LogicSolutionBackenProject

3. Restaurar los paquetes de NuGet:

    dotnet restore

4. Aplicar las migraciones a la base de datos:

    dotnet ef database update

5. Ejecutar la aplicación:

    dotnet run

---

## 🔗 Frontend Recomendado | Recommended Frontend
Para interactuar visualmente con esta API y probar la integración de mapas, visita el repositorio del cliente web:
* [LogicSolutionFrontend](https://github.com/HEO-80/LogicSolutionFrontend)

---

## ✒️ Autor | Author
**Héctor Oviedo** - *Fullstack Developer* - [LinkedIn](https://www.linkedin.com/in/hectorob/)
