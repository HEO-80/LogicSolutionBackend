<div align="center">

# 🚚 LogicSolution Backend — Logistics REST API

<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white"/>
<img src="https://img.shields.io/badge/.NET_5.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/Entity_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white"/>
<img src="https://img.shields.io/badge/REST_API-FF6B6B?style=for-the-badge&logoColor=white"/>

**🌍 [English](#-english-version) · 🇪🇸 [Español](#-versión-en-español)**

<br/>

*REST API backend for a logistics management platform — transport hiring, shipment tracking and operations management.*

</div>

---

## 🇪🇸 Versión en Español

### 📝 Descripción

**LogicSolution Backend** es una API REST desarrollada en **.NET 5.0 (C#)** que actúa como el núcleo lógico de una plataforma de gestión logística. Gestiona la persistencia de datos, la lógica de negocio para la contratación de transportes y expone los endpoints necesarios para el seguimiento de operativas.

> 🔗 **Proyecto completo:** este backend fue desarrollado en paralelo con [LogicSolutionFrontend](https://github.com/HEO-80/LogicSolutionFrontend) como proyecto final de ciclo.

---

### ✨ Características Principales

- 🏛️ **Arquitectura en capas** — separación clara de responsabilidades: Controllers → Services → Data → Models
- 📦 **Patrón DTO** — Data Transfer Objects para optimizar y asegurar el intercambio de información
- 🗄️ **Entity Framework Core** — ORM con migraciones para gestión completa de la base de datos
- 💉 **Inyección de dependencias** — Interfaces para desacoplamiento y testabilidad
- 🔌 **API RESTful** — Endpoints estructurados para integración fluida con el frontend

---

### 🛠️ Tech Stack

| Área | Tecnología |
|:---|:---|
| Framework | ASP.NET Core (.NET 5.0) |
| Lenguaje | C# |
| ORM | Entity Framework Core |
| Base de datos | SQL Server |
| Arquitectura | REST + Layered Architecture |
| Patrón de datos | DTO (Data Transfer Objects) |

---

### 🏗️ Estructura del Proyecto
```
LogicSolutionBackenProject/
├── Controllers/        # Puntos de entrada — manejan peticiones HTTP
├── Services/           # Lógica de negocio encapsulada
├── Interfaces/         # Contratos para inyección de dependencias
├── Models/             # Entidades de dominio (vehículos, envíos, etc.)
├── Data/               # DbContext de Entity Framework
├── Dtos/               # Objetos de transferencia de datos
├── Migrations/         # Migraciones de base de datos
└── appsettings.json    # Configuración y connection string
```

---

### 🚀 Instalación y Ejecución Local

**Prerrequisitos**
- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- SQL Server (o compatible) configurado en `appsettings.json`

**1. Clonar el repositorio**
```bash
git clone https://github.com/HEO-80/LogicSolutionBackend.git
cd LogicSolutionBackenProject
```

**2. Restaurar dependencias**
```bash
dotnet restore
```

**3. Configurar la base de datos**

Edita `appsettings.json` con tu connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVIDOR;Database=LogicSolutionDB;..."
}
```

**4. Aplicar migraciones**
```bash
dotnet ef database update
```

**5. Ejecutar la API**
```bash
dotnet run
```

La API estará disponible en `https://localhost:5001`

---

### 🔗 Proyecto Completo (Fullstack)

Este backend forma parte de un proyecto fullstack completo:

| Repo | Rol | Tech |
|:---|:---|:---|
| `LogicSolutionBackend` *(este)* | 🔧 API REST — lógica de negocio y datos | .NET 5.0 / C# |
| [`LogicSolutionFrontend`](https://github.com/HEO-80/LogicSolutionFrontend) | 🖥️ Cliente web — UI e integración de mapas | TypeScript |

---

### 🧑‍💻 Autor

**Héctor Oviedo** — Fullstack Developer

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/hectorob/)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/HEO-80)

---
---

## 🇬🇧 English Version

### 📝 Description

**LogicSolution Backend** is a REST API developed in **.NET 5.0 (C#)** that acts as the logical core of a logistics management platform. It handles data persistence, business logic for transport hiring, and exposes the necessary endpoints for operations tracking.

> 🔗 **Full project:** this backend was developed alongside [LogicSolutionFrontend](https://github.com/HEO-80/LogicSolutionFrontend) as a final cycle project.

---

### ✨ Key Features

- 🏛️ **Layered Architecture** — clear separation of concerns: Controllers → Services → Data → Models
- 📦 **DTO Pattern** — Data Transfer Objects to optimize and secure data exchange
- 🗄️ **Entity Framework Core** — ORM with migrations for complete database management
- 💉 **Dependency Injection** — Interfaces for decoupling and testability
- 🔌 **RESTful API** — structured endpoints for seamless frontend integration

---

### 🛠️ Tech Stack

| Area | Technology |
|:---|:---|
| Framework | ASP.NET Core (.NET 5.0) |
| Language | C# |
| ORM | Entity Framework Core |
| Database | SQL Server |
| Architecture | REST + Layered Architecture |
| Data Pattern | DTO (Data Transfer Objects) |

---

### 🏗️ Project Structure
```
LogicSolutionBackenProject/
├── Controllers/        # Entry points — handle HTTP requests
├── Services/           # Encapsulated business logic
├── Interfaces/         # Contracts for dependency injection
├── Models/             # Domain entities (vehicles, shipments, etc.)
├── Data/               # Entity Framework DbContext
├── Dtos/               # Data Transfer Objects
├── Migrations/         # Database migrations
└── appsettings.json    # Configuration and connection string
```

---

### 🚀 Local Setup

**Prerequisites**
- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- SQL Server configured in `appsettings.json`

**1. Clone the repository**
```bash
git clone https://github.com/HEO-80/LogicSolutionBackend.git
cd LogicSolutionBackenProject
```

**2. Restore dependencies**
```bash
dotnet restore
```

**3. Configure the database**

Edit `appsettings.json` with your connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=LogicSolutionDB;..."
}
```

**4. Apply migrations**
```bash
dotnet ef database update
```

**5. Run the API**
```bash
dotnet run
```

API available at `https://localhost:5001`

---

### 🔗 Full Stack Project

| Repo | Role | Tech |
|:---|:---|:---|
| `LogicSolutionBackend` *(this)* | 🔧 REST API — business logic & data | .NET 5.0 / C# |
| [`LogicSolutionFrontend`](https://github.com/HEO-80/LogicSolutionFrontend) | 🖥️ Web client — UI & maps integration | TypeScript |

---

### 🧑‍💻 Author

**Héctor Oviedo** — Fullstack Developer

[![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/hectorob/)
[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/HEO-80)

---

<div align="center">
  <sub>Proyecto Final de Ciclo · <strong>Héctor Oviedo</strong> · Zaragoza, España</sub>
</div>
