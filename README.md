# 🖥️ Tarea 4 – Simulador de Funcionamiento de un Monoprocesador

## 📋 Descripción

Este proyecto consiste en el desarrollo de un programa en **C#** que simula el comportamiento básico de un **sistema monoprocesador**, donde las tareas se ejecutan **secuencialmente, una a la vez**, sin multitarea ni paralelismo.

El objetivo es comprender cómo funcionan los sistemas básicos que procesan una tarea a la vez, lo cual permite visualizar claramente el flujo de ejecución y el tiempo invertido por cada proceso individual.

## ⚙️ Funcionalidades

* ✅ **Clase Tarea** – Representa una tarea con nombre y duración, con un método `Ejecutar()` que simula su ejecución mostrando en consola cuándo inicia y finaliza.
* ✅ **Clase Monoprocesador** – Administra una cola de tareas. Permite agregarlas y ejecutarlas en orden de llegada.
* ✅ **Simulación de tiempo real** – Uso de temporizadores (`Thread.Sleep`) para simular el tiempo de ejecución de cada tarea.
* ✅ **Entrada flexible** – Permite agregar tareas de forma manual por el usuario o usar un conjunto de tareas predefinidas.
* ✅ **Visualización de progreso** – Muestra el estado de cada tarea durante su ejecución, indicando inicio y fin de cada una.

## 🧑‍🏫 Asignatura

Tarea correspondiente a la materia de **Programación Paralela**, impartida por el profesor **Wilmer Fariñas** en el **ITLA**.

## 👤 Autor

* **Nombre:** Christian Gil
* **Matrícula:** 2012-1036

## 🚀 Instrucciones de Uso

1. Clona este repositorio:

```bash
git clone https://github.com/chrisfelixgil/tarea-4-monoprocesador.git
```

2. Abre el proyecto en tu IDE de preferencia (Visual Studio recomendado).
3. Compila y ejecuta el programa.
4. Elige si deseas ingresar tareas manualmente o usar las predeterminadas.
5. Observa cómo se simula la ejecución secuencial de cada tarea.

## 🧰 Tecnologías Utilizadas

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge\&logo=c-sharp\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)

## 📜 Licencia

Distribuido bajo la licencia MIT. Puedes usar, modificar y compartir libremente este código.

