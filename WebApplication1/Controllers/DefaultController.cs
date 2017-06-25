using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DefaultController : ApiController
    {
        private CouncilObjectivesDBEntities1 _dbContext = new CouncilObjectivesDBEntities1(); 
        // GET: api/Default
        public IEnumerable<PopulationDto> Get(int speciesid)
        {
            var result = _dbContext
               .tblNames
               .Where(s => s.SpeciesID == speciesid)
               .Include("LU_Objectives")
               .Select(t => new PopulationDto
               {
                   PrimaryName = t.PrimaryName,
                   RecordType = t.RecordType,
                   SpeciesID = t.SpeciesID,
                   ObjectivesList = t.LU_Objectives.Select(p => new ObjectivesDto
                   {
                       NameID = p.NameID,
                       ProgramAdopted = p.ProgramAdopted

                   })
               });

            //return new string[] { "value1", "value2" };
            return result;
        }
            
               

        // GET: api/Default/5
        //public string Get(int id)
        //{
           // return "value";
        //}

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
