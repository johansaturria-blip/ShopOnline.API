# ShopOnline — Plataforma eCommerce

Sistema de comercio electrónico desarrollado en **ASP.NET Core (.NET)** aplicando principios de **Código Limpio (Clean Code)**, arquitectura modular y prácticas de **DevOps** con control de versiones distribuido en Git.

---

## Tabla de Contenidos
1. [Descripción del Proyecto](#descripción-del-proyecto)
2. [Arquitectura y Estructura del Repositorio](#arquitectura-y-estructura-del-repositorio)
3. [Roles y Responsabilidades del Equipo](#roles-y-responsabilidades-del-equipo)
4. [Estrategia de Ramas (Git Workflow)](#estrategia-de-ramas-git-workflow)
5. [Requisitos e Instalación](#requisitos-e-instalación)

---

## Descripción del Proyecto
**ShopOnline** es una aplicación diseñada para gestionar de forma ágil y escalable el catálogo de productos, categorías, carrito de compras y órdenes de clientes. El proyecto evoluciona de forma incremental para adaptarse rápidamente a cambios en las reglas de negocio del comercio electrónico.

---

## Arquitectura y Estructura del Repositorio

```text
ShopOnline/
├── ShopOnline.API/            # Proyecto principal ASP.NET Core Web API
│   ├── Controllers/           # Endpoints REST (Productos, Categorías)
│   ├── Models/                # Entidades del dominio
│   ├── DTOs/                  # Objetos de transferencia de datos
│   ├── Data/                  # Contexto de base de datos (EF Core)
│   └── Program.cs             # Configuración de servicios y pipeline HTTP
├── .gitignore                 # Exclusión de archivos compilados (bin/, obj/, .vs/)
├── ShopOnline.sln             # Archivo de solución de Visual Studio
└── README.md                  # Documentación técnica del proyecto
---

## Roles y Responsabilidades del Equipo

| Rol | Integrante | Responsabilidades Principales |
| :--- | :--- | :--- |
| **Líder Técnico / Arquitecto** | **Johan Eriberto** | Definición de la arquitectura modular, estándares de Código Limpio (*Clean Code*), revisión de código (*Pull Requests*) y gestión de ramas principales. |
| **Desarrollador Backend (.NET)** | **Johan Eriberto** | Diseño e implementación de endpoints REST en ASP.NET Core, modelos de dominio, DTOs y acceso a datos con Entity Framework Core. |
| **Desarrollador Frontend** | **Johan Eriberto** | Consumo de la API REST, diseño de interfaces de catálogo, carrito de compras y experiencia de usuario responsiva. |
| **Ingeniero QA / DevOps** | **Johan Eriberto** | Configuración de control de versiones en Git/GitHub, pruebas de integración de endpoints, validación de calidad y automatización de despliegues. |

---

## Estrategia de Ramas (Git Workflow)

* **`master`:** Rama principal con código estable y listo para producción.
* **`develop`:** Rama de integración donde convergen las funcionalidades completadas antes de pasar a producción.
* **`feature/catalogo-productos`:** Rama de desarrollo aislada para construir los endpoints y lógica del catálogo de productos.

---

## Requisitos e Instalación

1. Clonar el repositorio:
   ```bash
   git clone [https://github.com/johansaturria-blip/ShopOnline.API.git](https://github.com/johansaturria-blip/ShopOnline.API.git)