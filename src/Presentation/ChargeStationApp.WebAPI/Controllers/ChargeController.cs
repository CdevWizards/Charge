using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using ChargeStationApp.Application.DTOs;
namespace ChargeStationApp.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChargeController : ControllerBase
{
    private readonly IMediator _mediator;

    public ChargeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ChargeStationDto>>> GetChargeStation()
    {
        var query = new GetAllChargeStationQuery();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
}