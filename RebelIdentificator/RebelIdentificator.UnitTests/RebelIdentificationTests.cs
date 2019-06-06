using Microsoft.VisualStudio.TestTools.UnitTesting;
using RebelIdentificator.Models;

namespace RebelIdentificator.UnitTests
{
    [TestClass]
    public class RebelIdentificationTests
    {
        [TestMethod]
        public void RebelIdentification_RebelIdenfitied_ReturnsTrue()
        {
            // Arrange
            string name = "Rebel_01", planet = "Planet_01";
            string expected = $"Rebel {name} on {planet}";

            // Act
            var rebelInfo = new RebelIdentificationReply
            {
                Name = name,
                Planet = planet
            };
            string actual = $"Rebel {rebelInfo.Name} on {rebelInfo.Planet}";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Custom_Exceptions.CustomException))]
        public void RebelIdentification_RebelName_IsNullAndThrowCustomException()
        {
            Rebel rebel = new Rebel()
            {
                Name = null,
                Planet = "Tierra"
            };

            if (rebel.Name == null)
                throw new Custom_Exceptions.CustomException("The name or the planet can not be null");
        }

        [TestMethod]
        [ExpectedException(typeof(Custom_Exceptions.CustomException))]
        public void RebelIdentification_RebelPlanet_IsNullAndThrowCustomException()
        {
            Rebel rebel = new Rebel()
            {
                Name = "Carlos",
                Planet = null
            };

            if (rebel.Planet == null)
                throw new Custom_Exceptions.CustomException("The name or the planet can not be null");
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void RebelIdentification_CustomException_CaughtSuccessfully()
        {
            Rebel rebel = new Rebel()
            {
                Name = "Carlos",
                Planet = null
            };

            try
            {
                throw new Custom_Exceptions.CustomException("The name or the planet can not be null");
            }
            catch (Custom_Exceptions.CustomException)
            {
                Assert.Fail();
            }
            catch (System.Exception)
            {
            }
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void RebelIdentification_File_ExceptionCaught()
        {
            Rebel rebel = new Rebel()
            {
                Name = "Carlos",
                Planet = "Tierra"
            };

            try
            {
                System.IO.File.AppendAllText(@"Ñ:\Rebels.txt", $"Rebel { rebel.Name } on { rebel.Planet } at { System.DateTime.Now } {System.Environment.NewLine}");
            }
            catch (Custom_Exceptions.CustomException)
            {
            }
            catch (System.Exception)
            {
                Assert.Fail();
            }
        }
    }
}
