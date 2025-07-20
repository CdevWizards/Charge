using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ChargeStationApp.Application.DTOs;
using ChargeStationApp.Application.Interfaces;
using ChargeStationApp.Domain.Entities;
using MediatR;

namespace ChargeStationApp.Application.Features.ChargeStations.Queries.GetAllChargeStations;

public class GetAllChargeStationsQueryHandler : IRequestHandler<GetAllChargeStationsQuery, IEnumerable<ChargeStationDto>>
{
    private readonly IRepository<ChargeStation> _repository;
    private readonly IMapper _mapper;

    public GetAllChargeStationsQueryHandler(IRepository<ChargeStation> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ChargeStationDto>> Handle(GetAllChargeStationsQuery request, CancellationToken cancellationToken)
    {
        var ChargeStation = await _repository.GetActiveAsync();
        return _mapper.Map<IEnumerable<ChargeStationDto>>(ChargeStation);
    }
}
