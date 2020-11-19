using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackHackaton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        DataAbstractionLayer dataAbstraction = new DataAbstractionLayer();
        [HttpGet]
        public List<Tournaments> GetAllTournaments()
        {

            return dataAbstraction.SelectAllTournaments();

        }
    }
}
