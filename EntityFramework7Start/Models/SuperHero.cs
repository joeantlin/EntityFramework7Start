﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWork7Start
{
    public class SuperHero
	{
        public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;  
		public string Place { get; set; } = string.Empty;
	}
}
