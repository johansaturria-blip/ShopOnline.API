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