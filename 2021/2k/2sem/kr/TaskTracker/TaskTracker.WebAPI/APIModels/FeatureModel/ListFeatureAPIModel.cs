using TaskTracker.Core.Entities;
using TaskTracker.WebAPI.APIModels.ProjectAPIModels;

namespace TaskTracker.WebAPI.APIModels.FeatureModel;

public class ListFeatureAPIModel: UpdateProjectAPIModel
{
    public int Id { get; set; }
        
    public ListFeatureAPIModel(int id, string name) : base(name) { Id = id; }
    
    public static ListProjectAPIModel FromFeatures(Feature feature)
    {
        var model = new ListProjectAPIModel(feature.Id, feature.Name)
        {
            Description = feature.Description,
            
        };            

        return model;
    }
}