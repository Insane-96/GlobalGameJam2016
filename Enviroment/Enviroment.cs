﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aiv.Engine;

namespace GlobalGameJam2016.Enviroment
{
	class Enviroment:GameObject
	{
        public static float gravity;
		public Enviroment()
		{
            gravity = 10;
		}
        
		public override void Start()
		{
			base.Start();
		}

		public override void Update()
		{
			base.Update();
		}

	}
}