using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RiotSharp;
using RiotSharp.Misc;
using RiotBack.Models;
using RiotSharp.Endpoints.Interfaces.Static;

namespace RiotBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionsController : ControllerBase
    {


        static RiotApi api = RiotApi.GetDevelopmentInstance("RGAPI-068b1991-d5b8-42df-8f0f-d8ce12262af2");
       
        // GET: api/Champions
        [HttpGet]
        public async Task<string> Get()
        {
            
            var championsList = new List<ChampionModel>();

            try
            {
                var championRotation = await api.Champion.GetChampionRotationAsync(Region.Lan);
                foreach (var champion in championRotation.FreeChampionIds)
                {
                    
                }
                return "";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }                                
        }

     // GET: api/Champions/5
     [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/Champions
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/Champions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
