# C5-T29 UnitTest
Ejercicio de realización de test

## Enunciado: Tarea Pruebas Unitarias
- Archivos adjuntos: [Geometria.cs](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c5-T29-UnitTest-08-2023/tree/main/Recursos)

- Crear un proyecto en C# de WF .NET Core  e incluye la funcionalidad de la clase adjunta Geometría.
- Realiza todos los test de prueba necesarios para tener una cobertura del 100% en la clase Geometria.cs.
- Una vez tengas esto implementa la interfaz de usuario para aplicar esta funcionalidad.

## Librerías para hacer pruebas en .NET
- MSTest *(Viene incorporado en Visual Studio)*
- [NUnit](https://www.nuget.org/packages/NUnit)
- [xUnit](https://www.nuget.org/packages/xunit/)

## Pasos durante la resolución del ejercicio
1. Crear proyecto .NET
2. Instalar paquete [xUnit](https://www.nuget.org/packages/xunit/)
3. Crear proyecto xUnit:
    - Hacer clic derecho en la solución en el Explorador de Soluciones.
    - Selecciona "Agregar" > "Nuevo Proyecto".
    - En la ventana de "Nuevo Proyecto", buscar "Proyecto de Pruebas xUnit".
    - Seleccionar "Proyecto de Pruebas xUnit" y dale un nombre. `NombreProyectoTests`
    - Hacer clic en "Crear".
4. Agregar referencia del proyecto... (botón derecho en "Dependencias" en el proyecto de test).
5. Crear nueva clase para hacer pruebas `NombreClaseTest`
6. Verificar que la clase del proyecto a utilizar sea accesible. `public class GeometriaTest { ... }`
7. En la nueva clase de pruebas:
    - Importar Xunit. `using Xunit;`
    - Crear un método con el mismo nombre del método que vamos a testear.
    - Convertir el método en una prueba escribiendo encima: `[Fact]`. <br>*Para usar valores múltiples, revisar las notas.*
    - Crear una instancia de la clase. `Geometria g = new Geometria();`
    - Ejecutar un método de la instancia de esa clase almacenando el resultado. `int result = g.areacuadrado(2);`
    - Verificar el resultado. `Assert.Equal(4, result);`

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xunit;

    namespace Geometria.Tests
    {
        public class GeometriaTest
        {
            [Fact]
            public void areacuadrado()
            {
                Geometria g = new Geometria();
                int result = g.areacuadrado(2);

                Assert.Equal(4, result);
            }
        }
    }
    ```

## Notas
- Se ha cambiado el nivel de protección de la clase *"Geometria.cs"* para que sea accesible desde los tests.<br>
`class Geometria` -> `public class Geometria`
- Se ha cambiado el namespace de la clase *"GeometriaTest.cs"* al mismo de la clase para poder acceder más fácilmente.<br>
`namespace T29_UnitTest.Tests` -> `namespace Geometria.Tests`
- Es posible que la versión de xUnit del `proyecto` y del `proyectoTest` no sean la misma, en ese caso:
    1. Ir a *"Administrar paquetes NuGet para la solución..."*.
    2. Instalado > xunit
    3. Comprobar que las versiones coincidan para saber si hay que actualizarlas.
- En caso de usar **MSTest**
    - Importar: `using Microsoft.VisualStudio.TestTools.UnitTesting;`
    - Atributos: `[TestClass]`, `[TestMethod]` ...
- En caso de usar **NUnit**
    - Importar: `using NUnit.Framework;`
    - Atributos: `[TestFixture]`, `[Test]` ...
- Pruebas con múltiples valores:
    - Atributos: `[Theory]`, `[InlineData()]`
    - Ejemplo:
        ```csharp
        [Theory]
        [InlineData(1, "Cuadrado")]
        [InlineData(2, "Círculo")]
        [InlineData(3, "Triángulo")]
        public void figura(int figura, string resultadoEsperado)
        {
            Geometria g = new Geometria();
            string result = g.figura(figura);
            Assert.Equal(resultadoEsperado, result);
        }
        ```