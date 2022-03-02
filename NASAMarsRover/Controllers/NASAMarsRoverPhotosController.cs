using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NASAMarsRover.Services;
using NASAMarsRover.Model;

namespace NASAMarsRover.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NASAMarsRoverPhotosController : ControllerBase
    {

        public NASAMarsRoverPhotosController() { }

        [HttpGet(Name = "GetMarsPhotos")]
        public ActionResult<MarsRoverPhotos> Get(string earth_date)
        {
            string key = "b77yJnEH9ddWaSqOJgbm8wSir2Wgt62iPmmRa03e";
            string baseUrl = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?";
            string param = $"earth_date={earth_date}&api_key={key}";
            string apiUrl = baseUrl + param;
            MarsRoverPhotos marsRoverPhotos = new MarsRoverPhotos();

            var apiResponse = Call.Instance.CallThirdPartyAPI(apiUrl);

            if (apiResponse.IsSuccessStatusCode)
            {
                marsRoverPhotos = JsonConvert.DeserializeObject<MarsRoverPhotos>(apiResponse.Content.ReadAsStringAsync().Result);

                if (marsRoverPhotos.Photos.Any())
                {
                    string directoryName = $"Mars Rover Photos {earth_date}";
                    string directory = Files.Instance.CreateDirectory(directoryName);

                    Files.Instance.DownloadPhoto(marsRoverPhotos, directory);
                    marsRoverPhotos.TotalPhotoDownloaded = marsRoverPhotos.Photos.Count();
                    marsRoverPhotos.FolderPath = directory.Replace(@"\", @"/");
                }
            }

            return marsRoverPhotos;
        }

    }
}