using System;

namespace ATV_GeometricShape.Circle
{
    internal class Circle : GeometricShape
    {
        public float pi = 3.1415f;
        public float raio;

        public override float Area()
        {
            return (pi * raio);
        }
        public override float Perimeter()
        {
            return (2 * pi * raio);
        }

    }
}
