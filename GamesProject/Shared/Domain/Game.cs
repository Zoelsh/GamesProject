﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesProject.Shared.Domain
{
    public class Game : BaseDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int GamePublisherId { get; set; }
        public virtual GamePublisher GamePublisher { get; set; }
        public int AgeRatingId { get; set; }
        public virtual AgeRating AgeRating { get; set; }
        public virtual List<Booking> Bookings { get; set; }


    }
}
