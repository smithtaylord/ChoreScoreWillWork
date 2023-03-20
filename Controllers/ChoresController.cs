using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChoreScoreWillWork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;
        public ChoresController(ChoresService choresService)
        {
            _choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetAll()
        {
            try
            {
                return Ok(_choresService.GetAllChores());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Chore> GetOneChore(int id)
        {
            try
            {
                Chore chore = _choresService.GetOneChore(id);
                return Ok(chore);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
        {
            try
            {
                Chore chore = _choresService.CreateChore(choreData);
                return Ok(chore);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{choreId}")]
        public ActionResult<string> RemoveChore(int choreId)
        {
            try
            {
                string message = _choresService.RemoveChore(choreId);
                return Ok(message);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}/complete")]
        public ActionResult<Chore> CompleteChore(int id)
        {
            try
            {
                Chore chore = _choresService.CompleteChore(id);
                return Ok(chore);
            }
            catch (System.Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}