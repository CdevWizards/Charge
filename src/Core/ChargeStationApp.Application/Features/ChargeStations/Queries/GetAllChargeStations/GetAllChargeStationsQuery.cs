using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargeStationApp.Application.DTOs;
using MediatR;

namespace ChargeStationApp.Application.Features.ChargeStations.Queries.GetAllChargeStations;

    public record GetAllChargeStationsQuery : IRequest<IEnumerable<ChargeStationDto>>;