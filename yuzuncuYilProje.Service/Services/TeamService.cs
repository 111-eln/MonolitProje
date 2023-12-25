using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yuzuncuYilProje.Core.Models;
using yuzuncuYilProje.Core.Repositories;
using yuzuncuYilProje.Core.Services;
using yuzuncuYilProje.Core.UnitOfWorks;

namespace yuzuncuYilProje.Service.Services
{
    public class TeamService : Service<Team>, ITeamService
    {
        public TeamService(IGenericRepository<Team> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
