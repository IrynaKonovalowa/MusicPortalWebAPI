﻿using System.ComponentModel.DataAnnotations;

namespace MusicPortalWebAPI.Models
{
    public class Genre
    {
        public int Id { get; set; }		
		public string Name { get; set; }
        virtual public ICollection<Song>? Songs { get; set; }
    }
}
