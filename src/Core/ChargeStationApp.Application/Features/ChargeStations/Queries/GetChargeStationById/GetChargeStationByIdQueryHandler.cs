using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargeStationApp.Application.DTOs;
using ChargeStationApp.Application.Interfaces;
using ChargeStationApp.Domain.Entities;
using MediatR;
using AutoMapper;


namespace ChargeStationApp.Application.Features.ChargeStations.Queries.GetChargeStationById;

public class GetChargeStationByIdQueryHandler : IRequestHandler<GetChargeStationByIdQuery, ChargeStationDto>
{
    private readonly IRepository<ChargeStation> _repository;
    private readonly IMapper _mapper;

    public GetChargeStationByIdQueryHandler(IRepository<ChargeStation> repository)
    {
        _repository = repository;
    }

    public async Task<ChargeStationDto> Handle(GetChargeStationByIdQuery request, CancellationToken cancellationToken)
    {
        var ChargeStation = await _repository.GetByIdAsync(request.id);
        if (ChargeStation == null)
        {
            throw new ArgumentException($"ChargeStation Id{request.id} not found ");
        }
        return _mapper.Map<ChargeStationDto>(ChargeStation);
    }
}