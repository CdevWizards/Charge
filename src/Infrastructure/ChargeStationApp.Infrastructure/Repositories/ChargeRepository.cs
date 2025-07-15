using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargeStationApp.Domain.Entities;
using ChargeStationApp.Infrastructure.Context;

namespace ChargeStationApp.Infrastructure.Repositories
{
    public class ChargeRepository : BaseRepository<ChargeStation>
    {
        public ChargeRepository(ChargeDbContext context) : base(context)
        {
        }
    }
}