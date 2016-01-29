﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aiv.Engine;


namespace GlobalGameJam2016.EnemyList
{
    class EnemyEarth : Enemy
    {
        public EnemyEarth(Engine engine, int width, int height, bool isEasy) : base(width, height, isEasy, "Enemy_Earth")
        {
            if(isEasy)
            {
                Health = 1;
            }
            else
            {
                Health = 2;
            }
        }

        public override void Start()
        {
            base.Start();
        }
        public override void Movement()
        {
            base.Movement();
        }
        public override void Update()
        {
            base.Update();
            Movement();
        }


    }
}