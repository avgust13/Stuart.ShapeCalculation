using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpencerStuart.ShapeCalculation.Data;

namespace SpencerStuart.ShapeCalculation.Tests
{
    [TestClass]
    public class ShapeTests
    {
        [TestMethod]
        public void ShouldReturnCorrectAreaOfTriangle()
        {
            //Arrange
            var triangle = new Triangle(2, 3);//3

            //Act
            //Assert
            Assert.AreEqual(triangle.GetArea(), 3);
        }

        [TestMethod]
        public void ShouldReturnCorrectAreaOfSquare()
        {
            //Arrange
            var square = new Square(5);//25

            //Act
            //Assert
            Assert.AreEqual(square.GetArea(), 25);
        }

        [TestMethod]
        public void ShouldReturnCorrectAreaOfCircle()
        {
            //Arrange
            var circle = new Circle(5);

            //Act
            //Assert
            Assert.AreEqual(circle.GetArea(), 78.5375f);
        }



        [TestMethod]
        public void ShouldReturnCorrectAreaOfRectangle()
        {
            //Arrange
            var rectangle = new Rectangle(2, 5);//10

            //Act
            //Assert
            Assert.AreEqual(rectangle.GetArea(), 10);
        }

        [TestMethod]
        public void ShouldReturnCorrectCornersOfTriangle()
        {
            //Arrange
            var triangle = new Triangle(2, 3);//3

            //Act
            //Assert
            Assert.AreEqual(triangle.GetCorners(), 3);
        }

        [TestMethod]
        public void ShouldReturnCorrectCornersOfSquare()
        {
            //Arrange
            var square = new Square(5);//25

            //Act
            //Assert
            Assert.AreEqual(square.GetCorners(), 4);
        }

        [TestMethod]
        public void ShouldReturnCorrectCornersOfRectangle()
        {
            //Arrange
            var rectangle = new Rectangle(2, 5);//10

            //Act
            //Assert
            Assert.AreEqual(rectangle.GetCorners(), 4);
        }

        [TestMethod]
        public void ShouldReturnCorrectCornersOfCircle()
        {
            //Arrange
            var circle = new Circle(5);

            //Act
            //Assert
            Assert.AreEqual(circle.GetCorners(), 0);
        }
    }
}
