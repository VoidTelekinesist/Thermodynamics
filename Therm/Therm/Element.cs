﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therm
{
	public class Element
	{
		public string search = "";
		public string state = "def";
		public double mult = 1;
		public double H, S, G;
		public bool foundH = true, foundS = true, foundG = true;
		public Element()
		{

		}
	}
}
