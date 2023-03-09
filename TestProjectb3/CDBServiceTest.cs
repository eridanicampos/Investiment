using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Services.Models;
using Services.Services;

namespace TestProjectb3
{
    [TestClass]
    public class CDBServiceTest
    {
        [TestMethod]
        public async Task CalcularCDBInvestimento_Returns_Correct_Value()
        {
            // Arrange
            var cdbService = new CDBService();
            var investimentCDBModel = new InvestimentCDBModel { amount = 1000m, months = 12 };

            // Act
            var result = await cdbService.CalcularCDBInvestimento(investimentCDBModel);

            // Assert
            Xunit.Assert.Equal(1061.97m, result);
        }

        [TestMethod]
        public async Task CalcularCDBInvestimento_Returns_Correct_Value_For_6_Months()
        {
            // Arrange
            var cdbService = new CDBService();
            var investimentCDBModel = new InvestimentCDBModel { amount = 1000m, months = 6 };

            // Act
            var result = await cdbService.CalcularCDBInvestimento(investimentCDBModel);

            // Assert
            Xunit.Assert.Equal(1022.52m, result);
        }

        [TestMethod]
        public async Task CalcularCDBInvestimento_Returns_Correct_Value_For_24_Months()
        {
            // Arrange
            var cdbService = new CDBService();
            var investimentCDBModel = new InvestimentCDBModel { amount = 1000m, months = 24 };

            // Act
            var result = await cdbService.CalcularCDBInvestimento(investimentCDBModel);

            // Assert
            Xunit.Assert.Equal(1119.10m, result);
        }

        [TestMethod]
        public async Task CalcularCDBInvestimento_Returns_Correct_Value_For_36_Months()
        {
            // Arrange
            var cdbService = new CDBService();
            var investimentCDBModel = new InvestimentCDBModel { amount = 1000m, months = 36 };

            // Act
            var result = await cdbService.CalcularCDBInvestimento(investimentCDBModel);

            // Assert
            Xunit.Assert.Equal(1216.65m, result);
        }


    }
}