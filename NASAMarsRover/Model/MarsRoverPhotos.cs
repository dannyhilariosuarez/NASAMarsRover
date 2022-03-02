namespace NASAMarsRover.Model
{
    public class MarsRoverPhotos
    {  
        public IEnumerable<Photos> Photos { get; set; }
        public string? FolderPath { get; set; }
        public int TotalPhotoDownloaded { get; set; } 
    }
}
