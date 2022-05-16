namespace TaskTracker.WebAPI.APIModels.FeatureModel;

public class CreateFeatureAPIModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public CreateFeatureAPIModel(string name) { Name = name; }  
    
}

