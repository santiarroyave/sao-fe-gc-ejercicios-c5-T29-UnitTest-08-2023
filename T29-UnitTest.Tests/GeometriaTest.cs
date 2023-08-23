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