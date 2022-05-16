using Microsoft.AspNetCore.Mvc;
using TaskTracker.Core.Entities;
using TaskTracker.Core.Middlewares;
using TaskTracker.Core.Repositories;
using TaskTracker.WebAPI.APIModels;
using TaskTracker.WebAPI.APIModels.FeatureModel;
using TaskTracker.WebAPI.APIModels.ProjectAPIModels;
using ILogger = Microsoft.Build.Framework.ILogger;

namespace TaskTracker.WebAPI.Controllers;


[Route("api/projects")]
[ApiController]
public class FeatureController : ControllerBase
{

    private readonly FeatureRepository _featureRepository;
    private readonly LoggerMiddleware _loggerMiddleware;


    public FeatureController(FeatureRepository featureRepository, LoggerMiddleware loggerMiddleware)
    {
        _loggerMiddleware = loggerMiddleware;
        _featureRepository = featureRepository;
    }

    public ActionResult<FeatureAPIModel> GetById(int featureID)
    {
        try
        {
            var feature = _featureRepository.GetById(featureID);
            if (feature == null)
                return NotFound();

            var result = FeatureAPIModel.FromFeature(feature);
            _loggerMiddleware.LogFile(feature.ToString());

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
            var feature = new Feature(model.Name);

            feature.Description = model.Description;
            _featureRepository.Add(feature);
            _loggerMiddleware.LogFile(feature.ToString());
            return CreatedAtAction(nameof(GetById), new { projectId = feature.Id }, model);
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
            _loggerMiddleware.LogFile(feature.ToString());
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