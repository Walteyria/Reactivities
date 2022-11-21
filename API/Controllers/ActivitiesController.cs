using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ActivitiesController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities(CancellationToken ct)
    {
        return await Mediator!.Send(new List.Query(), ct);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetActivity(Guid id, CancellationToken ct)
    {
        return HandleResult(await Mediator!.Send(new Details.Query{Id = id}, ct));
    }

    [HttpPost]
    public async Task<IActionResult> CreateActivity(Activity activity, CancellationToken ct)
    {
        return Ok(await Mediator!.Send(new Create.Command{Activity = activity}, ct));
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> EditActivity(Guid id, Activity activity, CancellationToken ct)
    {
        activity.Id = id;
        return Ok(await Mediator!.Send(new Edit.Command{Activity = activity}, ct));
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteActivity(Guid id, CancellationToken ct)
    {
        return Ok(await Mediator!.Send(new Delete.Command {Id = id}, ct));
    }
}