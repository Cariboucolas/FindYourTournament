using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackHackaton.BDD.ClassesEfCore;


namespace BackHackaton.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FYTController : ControllerBase
    {
        [HttpGet("tournament")]
        public List<Tournament> GetAllTournaments()
        {

            return SelectData.SelectAllTournaments();

        }

        [HttpGet("knight")]
        public List<Knight> GetAllKnights()
        {
            return SelectData.SelectAllKnights();
        }

        [HttpGet("knight/alive")]
        public List<Knight> GetAliveKnights()
        {
            return SelectData.SelectAliveKnights();
        }

        [HttpGet("knight/haveAMount")]
        public List<Knight> GetKnightsHaveAMount()
        {
            return SelectData.SelectKnightsHaveAMount();
        }
    }
}
