using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using knihovna;

namespace zaseprace
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1Name()
        {
            GameCharacter character = new GameCharacter("Test");
            character.Name = "John";
            Assert.AreEqual("John", character.Name);
        }


        [TestMethod]
        public void TestMethod3Name_LevelInitializedTo1()
        {
            // Arrange
            GameCharacter character = new GameCharacter("Test");

            // Assert
            Assert.AreEqual(1, character.Level);
        }

        [TestMethod]
        public void TestMethod4Name_PositionXInitializedTo0()
        {
            // Arrange
            GameCharacter character = new GameCharacter("Test");

            // Assert
            Assert.AreEqual(0, character.PositionX);
        }

        [TestMethod]
        public void TestMethod5Name_PositionYInitializedTo0()
        {
            // Arrange
            GameCharacter character = new GameCharacter("Test");

            // Assert
            Assert.AreEqual(0, character.PositionY);
        }

        [TestMethod]
        public void TestMethod6Name_ChangePosition_PositionUpdatedCorrectly()
        {
            // Arrange
            GameCharacter character = new GameCharacter("Test");

            // Act
            character.ChangePosition(5, 10);

            // Assert
            Assert.AreEqual(5, character.PositionX);
            Assert.AreEqual(10, character.PositionY);
        }

        [TestMethod]
        public void TestMethod7Name_ToString_ReturnsCorrectString()
        {
            // Arrange
            GameCharacter character = new GameCharacter("Test");
            character.ChangePosition(3, 7);

            // Act
            string result = character.ToString();

            // Assert
            StringAssert.Contains("Jméno: Test", result);
            StringAssert.Contains("Level: 1", result);
            StringAssert.Contains("Pozice X: 3", result);
            StringAssert.Contains("Pozice Y: 7", result);
        }
    }
}
