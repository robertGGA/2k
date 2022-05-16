namespace TaskTracker.WebAPI.APIModels.FeatureModel;

public class UpdateFeatureAPIModel: CreateFeatureAPIModel
{
    public string Name { get; set; }
    public int Id { get; set; }


    public UpdateFeatureAPIModel(string name, int id) : base(name) { Id = id; }
}