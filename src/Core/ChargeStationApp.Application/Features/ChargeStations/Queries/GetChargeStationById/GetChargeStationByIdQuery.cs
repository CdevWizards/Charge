using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargeStationApp.Application.DTOs;
using MediatR;

namespace ChargeStationApp.Application.Features.ChargeStations.Queries.GetChargeStationById
{
    public record GetChargeStationByIdQuery(int id) :IRequest<ChargeStationDto>
    {
        
    }
}