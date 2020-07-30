using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpencerStuart.ShapeCalculation.Data;
using SpencerStuart.ShapeCalculation.Enums;

namespace SpencerStuart.ShapeCalculation.Tests
{
    [TestClass]
    public class ShapeCollectionTests
    {
        [TestMethod]
        public void ShouldReturnCorrectAreaSumOfShapeCollection()
        {
            //Arrange
            var shapeCollection = new ShapeCollection();

            shapeCollection.Add(new Triangle(2, 3));//3
            shapeCollection.Add(new Square(2));//4
            shapeCollection.Add(new Square(3));//9
            shapeCollection.Add(new Circle(5));//78.5875

            //Act
            //Assert
            Assert.AreEqual(shapeCollection.AreaSum(), 94.5375f);
        }

        [TestMethod]
        public void ShouldReturnCorrectCornersSumOfShapeCollection()
        {
            //Arrange
            var shapeCollection = new ShapeCollection();

            shapeCollection.Add(new Triangle(2, 3));
            shapeCollection.Add(new Square(2));
            shapeCollection.Add(new Rectangle(4, 3));
            shapeCollection.Add(new Circle(4));

            //Act
            //Assert
            Assert.AreEqual(shapeCollection.CornerSum(), 11);
        }

        [TestMethod]
        public void ShouldReturnCorrectHappyAreaSumOfShapeCollection()
        {
            //Arrange
            var shapeCollection = new ShapeCollection();

            shapeCollection.Add(new Triangle(2, 3) { Mood = MoodTypes.Happy });//3
            shapeCollection.Add(new Square(2) { Mood = MoodTypes.Happy });//4
            shapeCollection.Add(new Square(3) { Mood = MoodTypes.Happy });//9
            shapeCollection.Add(new Circle(5) { Mood = MoodTypes.Happy });//78.5875

            //Act
            //Assert
            Assert.AreEqual(shapeCollection.AreaSum(), 94.5375f * 2);
        }

        [TestMethod]
        public void ShouldReturnCorrectSuperHappyAreaSumOfShapeCollection()
        {
            //Arrange
            var shapeCollection = new ShapeCollection();

            shapeCollection.Add(new Triangle(2, 3) { Mood = MoodTypes.SuperHappy });//3
            shapeCollection.Add(new Square(2) { Mood = MoodTypes.SuperHappy });//4
            shapeCollection.Add(new Square(3) { Mood = MoodTypes.SuperHappy });//9
            shapeCollection.Add(new Circle(5) { Mood = MoodTypes.SuperHappy });//78.5875

            //Act
            //Assert
            Assert.AreEqual(shapeCollection.AreaSum(), 94.5375f * 3);
        }


        [TestMethod]
        public void ShouldReturnCorrectHappyCornersSumOfShapeCollection()
        {
            //Arrange
            var shapeCollection = new ShapeCollection();

            shapeCollection.Add(new Triangle(2, 3) { Mood = MoodTypes.Happy });
            shapeCollection.Add(new Square(2) { Mood = MoodTypes.Happy });
            shapeCollection.Add(new Rectangle(4, 3) { Mood = MoodTypes.Happy });
            shapeCollection.Add(new Circle(5) { Mood = MoodTypes.Happy });

            //Act
            //Assert
            Assert.AreEqual(shapeCollection.CornerSum(), 11 * 2 + 5);
        }

        [TestMethod]
        public void ShouldReturnCorrectSuperHappyCornersSumOfShapeCollection()
        {
            //Arrange
            var shapeCollection = new ShapeCollection();

            shapeCollection.Add(new Triangle(2, 3) { Mood = MoodTypes.SuperHappy });
            shapeCollection.Add(new Square(2) { Mood = MoodTypes.SuperHappy });
            shapeCollection.Add(new Rectangle(4, 3) { Mood = MoodTypes.SuperHappy });
            shapeCollection.Add(new Circle(5) { Mood = MoodTypes.SuperHappy });

            //Act
            //Assert
            Assert.AreEqual(shapeCollection.CornerSum(), 11 * 3 + 10);
        }
    }
}
