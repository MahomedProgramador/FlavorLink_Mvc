﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
	public class Ingredient
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Measurement { get; set; }
		public bool Selected { get; set; }

		public IEnumerable<int> SelectedIngredients { get; set; }
	}
}
