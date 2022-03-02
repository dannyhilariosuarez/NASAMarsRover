using NASAMarsRover.Model;
using System.Net;

namespace NASAMarsRover.Services
{
    public class Files
    {
        private static Files instance;

        private Files() { }

        public static Files Instance
        {
            get
            {
                if (instance == null)
                    instance = new Files();
                return instance;
            }
        }

        public string CreateDirectory(string directoryName)
        {
            string directory = System.Environment.GetEnvironmentVariable("TEMP");
            string path = System.IO.Path.Combine(directory, directoryName);
            bool folderExists = Directory.Exists(path);

            if (!folderExists)
                Directory.CreateDirectory(path);

            return path;
        }

        public void DownloadPhoto(MarsRoverPhotos marsRoverPhotos, string directory)
        {
            foreach (var src in marsRoverPhotos.Photos)
                SavePhoto(directory, src.Img_src);
        }

        public void SavePhoto(string directory, string url)
        {
            string file = System.IO.Path.GetFileName(url);
            WebClient client = new WebClient();

            client.DownloadFileAsync(new Uri(url), $"{directory}\\{file}");
        }

    }
}
