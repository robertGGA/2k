using TaskTracker.Core.Entities;

namespace TaskTracker.WebAPI.APIModels.FeatureModel;

public class FeatureAPIModel: UpdateFeatureAPIModel
{

    public FeatureAPIModel(int id, string name) : base(name, id) { }
    public string Name { get; set; }
    public string? Description { get; set; }
    
    public List<FeatureAPIModel>? Features { get; set; }
    
    public static new FeatureAPIModel FromFeature(Feature feature)
    {
        var model = new FeatureAPIModel(feature.Id, feature.Name)
        {
            Description = feature.Description,
           
        };
        return model;
    }
    
}