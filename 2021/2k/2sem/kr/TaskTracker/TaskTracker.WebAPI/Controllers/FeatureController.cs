using Microsoft.AspNetCore.Mvc;
using TaskTracker.Core.Entities;
using TaskTracker.Core.Repositories;
using TaskTracker.WebAPI.APIModels;
using TaskTracker.WebAPI.APIModels.FeatureModel;
using TaskTracker.WebAPI.APIModels.ProjectAPIModels;

namespace TaskTracker.WebAPI.Controllers;


[Route("api/projects")]
[ApiController]
public class FeatureController : ControllerBase
{

    private readonly FeatureRepository _featureRepository;

    public ActionResult<FeatureAPIModel> GetById(int featureID)
    {
        try
        {
            var feature = _featureRepository.GetById(featureID);
            if (feature == null)
                return NotFound();

            var result = FeatureAPIModel.FromFeature(feature);

            return Ok(result);
        }
        catch (Exception e)
        {
            return BadRequest("");
        }
    }
    
    [HttpPost]
    public ActionResult<CreateFeatureAPIModel> CreateProject([FromBody]CreateProjectAPIModel model)
    {
        try
        {
            var project = new Feature(model.Name);

            project.Description = model.Description;
            _featureRepository.Add(project);

            return CreatedAtAction(nameof(GetById), new { projectId = project.Id }, model);
        }
        catch (Exception ex)
        {
            return BadRequest(new ErrorAPIModel(ex.Message));
        }
    }
    
    [HttpDelete("{featureId:int}")]
    public IActionResult DeleteFeature(int featureId)
    {
        try
        {
            var feature = _featureRepository.GetById(featureId);
            if (feature == null)
                return NotFound();

            _featureRepository.Delete(featureId);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(new ErrorAPIModel(ex.Message));
        }
    }

    [HttpGet]
    public IActionResult filterFeatureByName(string Name)
    {
        try
        {
            var features = _featureRepository.GetAll();

            var result =
                features
                    .Select(p => ListFeatureAPIModel.FromFeatures(p))
                    .Where(p => p.Name == Name)
                    .ToList();
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new ErrorAPIModel(ex.Message));
        }
    }
}