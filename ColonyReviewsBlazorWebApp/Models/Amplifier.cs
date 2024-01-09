using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColonyReviewsBlazorWebApp.Models
{

public class Amplifier
    {
        public int Id { get; set; }

        [NotMapped]
        [DataType(DataType.Upload)]
        public List<IFormFile>? ImageFiles { get; set; }
        public List<byte[]>? ImageDataList { get; set; }
        public List<string>? ImageTypeList { get; set; }

        [StringLength(255)]
        public string? ModelName { get; set; }
        [StringLength(350)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? PowerAt4Ohms { get; set; }

        [StringLength(50)]
        public string? PowerAt2Ohms { get; set; }

        [StringLength(50)]
        public string? PowerAt1Ohm { get; set; }

        [StringLength(50)]
        public string? BridgePowerAt40hms { get; set; }

        [StringLength(50)]
        public string? BridgePowerAt20hms { get; set; }

        [StringLength(50)]
        public string? OperatingVoltage { get; set; }

        [StringLength(50)]
        public string? CurrentDrawMusic { get; set; }

        [StringLength(50)]
        public string? CurrentDrawMax { get; set; }

        [StringLength(50)]
        public string? RecommendedFuseMusic { get; set; }

        [StringLength(50)]
        public string? TotalEfficiency { get; set; }

        [StringLength(50)]
        public string? DampingFactor { get; set; }

        [StringLength(50)]
        public string? FrequencyResponseMinus3dB { get; set; }

        [StringLength(50)]
        public string? SignalToNoiseRatio { get; set; }

        [StringLength(50)]
        public string? CrossoverHPF { get; set; }

        [StringLength(50)]
        public string? CrossoverLPF { get; set; }

        [StringLength(50)]
        public string? THDPlusN { get; set; }

        [StringLength(50)]
        public string? ProductDimensions1 { get; set; }

        [StringLength(50)]
        public string? ProductDimensions2 { get; set; }
        [Range(0, 999999)]
        public double? Price { get; set; }
    }

}
