using System;
using NUnit.Framework;
using ConsoleApp10;

namespace TestProject1
{
    public class ShapeFactoryTests
    {
        [Test]
        public void Circle_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            CircleFactory circleFactory = new CircleFactory(radius);
            IShape circle = circleFactory.CreateShape();
            
            // Act
            double area = circle.GetArea();
            
            // Assert
            Assert.AreEqual(Math.PI * radius * radius, area);
        }
        
        [Test]
        public void Triangle_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            TriangleFactory triangleFactory = new TriangleFactory(sideA, sideB, sideC);
            IShape triangle = triangleFactory.CreateShape();
            
            // Act
            double area = triangle.GetArea();
            
            // Assert
            Assert.AreEqual(6, area);
        }
        
        [Test]
        public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            TriangleFactory triangleFactory = new TriangleFactory(sideA, sideB, sideC);
            Triangle triangle = (Triangle)triangleFactory.CreateShape();
            
            // Act
            bool isRightTriangle = triangle.IsRightTriangle();
            
            // Assert
            Assert.IsTrue(isRightTriangle);
        }
        
        [Test]
        public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;
            double sideC = 4;
            TriangleFactory triangleFactory = new TriangleFactory(sideA, sideB, sideC);
            Triangle triangle = (Triangle)triangleFactory.CreateShape();
            
            // Act
            bool isRightTriangle = triangle.IsRightTriangle();
            
            // Assert
            Assert.IsFalse(isRightTriangle);
        }
    }
}