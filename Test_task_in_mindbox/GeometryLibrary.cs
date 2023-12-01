namespace Test_task_in_mindbox
{
    // Интерфейс для всех фигур
    public interface IShape
    {
        double CalculateArea();
    }

    // Круг
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.", nameof(radius));

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Треугольник
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник с такими сторонами не существует.", nameof(sideA));

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            // Формула Герона для вычисления площади треугольника
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            // Проверка на прямоугольность треугольника по теореме Пифагора
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                   Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
                   Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }

        private bool IsValidTriangle(double a, double b, double c)
        {
            return (a > 0 && b > 0 && c > 0) && (a + b > c && a + c > b && b + c > a);
        }
    }
}