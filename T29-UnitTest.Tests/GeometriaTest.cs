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
        //Métodos propios de clase Geometria
        //metodo area del cuadrado
        [Theory]
        [InlineData(2, 4)]
        [InlineData(0, 0)]
        public void areacuadrado(int num, int resultadoEsperado)
        {
            Geometria g = new Geometria();
            int result = g.areacuadrado(num);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del circulo
        [Theory]
        [InlineData(5)]
        [InlineData(0)]
        [InlineData(23)]
        public void areaCirculo(int num)
        {
            double resultadoEsperado = Math.PI * Math.Pow(num, 2);

            Geometria g = new Geometria();
            double result = g.areaCirculo(num);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del triangulo
        [Theory]
        [InlineData(4,9)]
        [InlineData(0,3)]
        [InlineData(23,4)]
        public void areatriangulo(int num1, int num2)
        {
            int resultadoEsperado = num1 * num2 / 2;

            Geometria g = new Geometria();
            int result = g.areatriangulo(num1,num2);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del rectangulo
        [Theory]
        [InlineData(4, 9)]
        [InlineData(0, 3)]
        [InlineData(23, 4)]
        public void arearectangulo(int num1, int num2)
        {
            int resultadoEsperado = num1 * num2;

            Geometria g = new Geometria();
            int result = g.arearectangulo(num1, num2);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del pentagono
        [Theory]
        [InlineData(4, 9)]
        [InlineData(0, 3)]
        [InlineData(23, 4)]
        public void areapentagono(int lateral, int apotema)
        {
            double resultadoEsperado = (5 * lateral * apotema) / 2;

            Geometria g = new Geometria();
            int result = g.areapentagono(lateral, apotema);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del rombo
        [Theory]
        [InlineData(4, 9)]
        [InlineData(0, 3)]
        [InlineData(23, 4)]
        public void arearombo(int diagonalMayor, int diagonalMenor)
        {
            double resultadoEsperado = (diagonalMayor * diagonalMenor) / 2;

            Geometria g = new Geometria();
            int result = g.arearombo(diagonalMayor, diagonalMenor);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del romboide
        [Theory]
        [InlineData(4, 9)]
        [InlineData(0, 3)]
        [InlineData(23, 4)]
        public void arearomboide(int a, int b)
        {
            int resultadoEsperado = a * b;

            Geometria g = new Geometria();
            int result = g.arearomboide(a, b);
            Assert.Equal(resultadoEsperado, result);
        }

        //metodo area del trapecio
        [Theory]
        [InlineData(4, 9, 8)]
        [InlineData(0, 3, 7)]
        [InlineData(23, 0, 3)]
        [InlineData(40, 5, 0)]
        [InlineData(0, 0, 0)]
        public void areatrapecio(int baseMayor, int baseMenor, int altura)
        {
            int resultadoEsperado = (baseMayor + baseMenor)/2 * altura;

            Geometria g = new Geometria();
            int result = g.areatrapecio(baseMayor, baseMenor, altura);
            Assert.Equal(resultadoEsperado, result);
        }

        //Selector de figuras
        [Theory]
        [InlineData(1, "Cuadrado")]
        [InlineData(2, "Círculo")]
        [InlineData(3, "Triángulo")]
        [InlineData(4, "Rectángulo")]
        [InlineData(5, "Pentágono")]
        [InlineData(6, "Rombo")]
        [InlineData(7, "Romboide")]
        [InlineData(8, "Trapecio")]
        [InlineData(0, "Default")]
        public void figura(int figura, string resultadoEsperado)
        {
            Geometria g = new Geometria();
            string result = g.figura(figura);
            Assert.Equal(resultadoEsperado, result);
        }

        //Getters y Setters
        [Fact]
        public void getId_constructor_por_defecto()
        {
            Geometria g = new Geometria();
            int result = g.getId();
            Assert.Equal(9, result);
        }

        [Fact]
        public void getId_constructor_personalizado()
        {
            Geometria g = new Geometria(2);
            int result = g.getId();
            Assert.Equal(2, result);
        }

        [Fact]
        public void setId()
        {
            Geometria g = new Geometria();
            g.setId(8334);
            int result = g.getId();
            Assert.Equal(8334, result);
        }

        [Fact]
        public void getNom()
        {
            Geometria g = new Geometria();
            string result = g.getNom();
            Assert.Equal("Default", result);
        }

        [Fact]
        public void setNom()
        {
            Geometria g = new Geometria();
            g.setNom("Rombo");
            string result = g.getNom();
            Assert.Equal("Rombo", result);
        }

        [Fact]
        public void getArea()
        {
            Geometria g = new Geometria();
            g.setArea(55);
            double result = g.getArea();
            Assert.Equal(55, result);
        }

        [Fact]
        public void setArea()
        {
            Geometria g = new Geometria();
            g.setArea(30);
            double result = g.getArea();
            Assert.Equal(30, result);
        }
    }
}