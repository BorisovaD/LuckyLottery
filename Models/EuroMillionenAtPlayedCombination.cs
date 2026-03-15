namespace LuckyLottery.Models
{
    using System.ComponentModel.DataAnnotations;

    public class EuroMillionenAtPlayedCombination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DatePlayed { get; set; }

        [Required]
        [Range(1, 50)]
        public int N1 { get; set; }

        [Required]
        [Range(1, 50)]
        public int N2 { get; set; }

        [Required]
        [Range(1, 50)]
        public int N3 { get; set; }

        [Required]
        [Range(1, 50)]
        public int N4 { get; set; }

        [Required]
        [Range(1, 50)]
        public int N5 { get; set; }

        [Required]
        [Range(1, 12)]
        public int Star1 { get; set; }

        [Required]
        [Range(1, 12)]
        public int Star2 { get; set; }

        public int Matches { get; set; }
    }
}
