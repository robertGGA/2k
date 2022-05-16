namespace TaskTracker.Core.Entities;

public class Feature
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string? Description { get; set; }
    
    public Boolean? isDeleted { get; set; }
    
    public Feature(string name) { Name = name; }

    public override string ToString()
    {
        return Id + " " + Name + " " + Description + " - Feature";
    }
}