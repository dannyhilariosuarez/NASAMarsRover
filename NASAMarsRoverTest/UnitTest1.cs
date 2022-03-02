using Microsoft.VisualStudio.TestTools.UnitTesting;  
using NASAMarsRover.Services;

namespace NASAMarsRoverTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CallThirdPartyAPI_ShouldReturnSussceess()
        {
            string earth_date = "2015-6-3";
            string key = "b77yJnEH9ddWaSqOJgbm8wSir2Wgt62iPmmRa03e";
            string baseUrl = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?";
            string param = $"earth_date={earth_date}&api_key={key}";
            string apiUrl = baseUrl + param;
             

            var result = Call.Instance.CallThirdPartyAPI(apiUrl);
            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.IsSuccessStatusCode);
        }

        [TestMethod]
        public void CreateDirectoryShouldReturnPath()
        { 
            string directoryName = "Mars Rover Photos 2015-6-3";

            var result = Files.Instance.CreateDirectory(directoryName);
            System.IO.Directory.Delete(result, true);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Contains(directoryName));

        }
          
    }
}