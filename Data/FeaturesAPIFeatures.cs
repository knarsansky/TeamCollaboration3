//namespace TeamCollaboration.Data.FeaturesAPI; // Razor won't recognize third level namespace
namespace TeamCollaboration.FeaturesAPI;

public class FeaturesType
{
    public double? FeatureId { get; set; }
    public double? ProductId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? RequestorEmail { get; set; }
    public string? DateAdded { get; set; }
}
