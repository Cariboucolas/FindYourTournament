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
    public class FYTController : ControllerBase
    {
        [HttpGet("tournament")]
        public List<Tournaments> GetAllTournaments()
        {

            return DataAbstractionLayer.SelectAllTournaments();

        }

        [HttpGet("knight")]
        public List<Knight> GetAllKnights()
        {
            return DataAbstractionLayer.SelectAllKnights();
        }
    }
}
