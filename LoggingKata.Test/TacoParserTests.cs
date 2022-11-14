using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // DONE: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.22997,-86.805275,Taco Bell Alabaste...", -86.805275)]
        [InlineData("33.470013, -86.816966, Taco Bell Birmingham...",-86.816966)]
        [InlineData("30.392476,-86.498396,Taco Bell Desti...", -86.498396)]
        [InlineData("30.357759,-87.163888,Taco Bell Gulf Breez...", -87.163888)]

        public void ShouldParseLongitude(string line, double expected)
        {
            // DONE: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }   


        //DONE: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // DONE: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }




    }
}
