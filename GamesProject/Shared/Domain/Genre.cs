using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GamesProject.Shared.Domain
{
    public class Genre : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
    }
}
