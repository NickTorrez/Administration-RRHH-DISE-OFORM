# Sistemas Gestion Empleados - [Ing-Sistemas]

## Descripción
Este proyecto consiste en el desarrollo de un **Sistema de Gestión de Empleados**, cuyo objetivo es administrar la información básica del personal de una empresa, incluyendo empleados, departamentos, puestos de trabajo y datos de contratación.

El sistema está orientado a fines **educativos y de aprendizaje**, aplicando conceptos de **programación orientada a objetos**, **estructuración de datos** y **buenas prácticas de desarrollo de software**.

---

## Objetivo del Sistema
Desarrollar un sistema que permita:

- Registrar y administrar empleados.
- Organizar a los empleados por departamentos.
- Definir y asignar puestos de trabajo.
- Gestionar la información relacionada con la contratación de cada empleado.

---

## Funcionalidades del Sistema

### Gestión de Empleados
El sistema permite administrar el ciclo de vida de un empleado dentro de la empresa.

#### Funcionalidades principales:
- Registrar un nuevo empleado.
- Dar de baja a un empleado.
- Consultar la información de un empleado.
- Actualizar los datos del empleado.
- Mantener un perfil básico del empleado.

#### Datos del empleado:
- Nombre y apellidos
- Número de identificación (cédula)
- Fecha de nacimiento (calculada a partir de la cédula)
- Estado civil:
  - Soltero
  - Casado
  - Unión de hecho
  - Divorciado
  - Viudo
- Número de hijos
- Correo electrónico
- Teléfono
- Domicilio

---

### Gestión de Departamentos
La empresa se organiza por áreas o departamentos, y cada empleado pertenece a uno de ellos.

#### Funcionalidades principales:
- Registrar nuevos departamentos.
- Consultar departamentos existentes.
- Asignar empleados a un departamento.
- Modificar la información de un departamento.

#### Datos del departamento:
- Identificador
- Nombre del departamento
- Descripción
- Estado (Activo / Inactivo)

---

### Gestión de Puestos
Los puestos representan los cargos funcionales dentro de la organización.

#### Funcionalidades principales:
- Registrar puestos de trabajo.
- Consultar puestos existentes.
- Asignar un puesto a un empleado.
- Actualizar la información del puesto.

#### Datos del puesto:
- Identificador
- Nombre del puesto
- Nivel o categoría
- Salario base (opcional)

---

### Gestión de Contratación
Cada empleado cuenta con un registro de contratación que define su relación laboral con la empresa.

#### Funcionalidades principales:
- Registrar la contratación de un empleado.
- Consultar información contractual.
- Actualizar datos del contrato.

#### Datos de la contratación:
- Fecha de inicio
- Tipo de contrato (temporal, indefinido, por servicios, etc.)
- Jornada laboral
- Estado del contrato

---

## Tecnologías Utilizadas
> *(Ajustar según el stack que implementes)*

- Lenguaje: C# / Python
- Framework: ASP.NET Core / Django
- Base de datos: SQL Server / PostgreSQL
- Control de versiones: Git y GitHub

---

## Instalación y Ejecución
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/nombre-del-repositorio.git
