using Microsoft.EntityFrameworkCore;
using TaskTracker.Core.Entities;
using TaskTracker.Core.Interfaces;
using TaskTracker.Infrastructure;

namespace TaskTracker.Core.Repositories;

public class FeatureRepository: IFeatureRepository
{
    private readonly ApplicationDbContext _context;
    public Feature? GetById(int id)        
            => _context
                .Features
                .Include(p => p.Id)
                .FirstOrDefault(p => p.Id == id);

    public void Add(Feature entity)
    {
        _context.Features.Add(entity);
        _context.SaveChanges();
    }
    
    public IEnumerable<Feature> GetAll()
        => _context
            .Features                
            .ToList();
        
    public void Update(Feature entity)
    {
        _context.Features.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var feature = _context
            .Features
            .FirstOrDefault(p => p.Id == id);
        if (feature == null || feature.isDeleted == true)
            throw new ArgumentException("Feature cannot be found");
        feature.isDeleted = true;
        _context.SaveChanges();
    }
}