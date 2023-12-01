using Test_task_in_mindbox;

namespace NUnitTests
{
    public class Tests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25).Within(0.001));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            Assert.That(triangle1.CalculateArea(), Is.EqualTo(6).Within(0.001));
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Triangle nonRightTriangle = new Triangle(2, 3, 4);

            Assert.IsTrue(rightTriangle.IsRightAngled());
            Assert.IsFalse(nonRightTriangle.IsRightAngled());
        }

        [Test]
        public void TriangleInvalidSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, -4, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(0, -4, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, -4, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 0, 0));
        }

        [Test]
        public void CircleInvalidRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Test]
        public void CircleCreation()
        {
            Circle circle = new Circle(7);
            Assert.That(circle.Radius, Is.EqualTo(7).Within(0.001));
        }

        [Test]
        public void TriangleCreation()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            Assert.That(triangle.SideA, Is.EqualTo(5).Within(0.001));
            Assert.That(triangle.SideB, Is.EqualTo(12).Within(0.001));
            Assert.That(triangle.SideC, Is.EqualTo(13).Within(0.001));
        }
    }
}