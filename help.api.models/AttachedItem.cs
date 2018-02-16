namespace help.api.models
{
    using System.ComponentModel.DataAnnotations;

    public class AttachedItem
    {
        public int Id { get; set; }

        [Required]
        public string FileType { get; set; }

        [Required]
        public string Path { get; set; }
    }
}