using TaskTracker.Core.Entities;

namespace TaskTracker.Core.Interfaces;

public interface IFeatureRepository
{
    Feature GetById(int id);
    
    IEnumerable<Feature> GetAll();
    
    void Add(Feature entity);
    
    void Update(Feature entity);
    
    void Delete(int id);
}