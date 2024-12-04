namespace JMWebAPI.Models.Entity
{
    public class Order3
    {
        public int DocEntry { get; set; }
        public int Linenum { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string FileSource { get; set; }
        public DateTime UploadTimestamp { get; set; }
    }
}
