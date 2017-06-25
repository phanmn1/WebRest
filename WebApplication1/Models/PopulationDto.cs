using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class PopulationDto
    {
        public int? SpeciesID { get; set; }
        public string PrimaryName { get; set; }
        public string RecordType { get; set; }
        public IEnumerable<ObjectivesDto> ObjectivesList { set; get; }

    }
}