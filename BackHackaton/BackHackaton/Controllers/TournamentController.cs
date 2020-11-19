using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackHackaton.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        [HttpGet]
        public List<Tournaments> GetAllTournaments()
        {

            return DataAbstractionLayer.SelectAllTournaments();

        }

        [HttpGet("knight")]
        public List<Knight> GetAllKnights()
        {
            List<Knight> listOfKnight = new List<Knight>();
            return DataAbstractionLayer.SelectAllKnights();
        }
    }
}
