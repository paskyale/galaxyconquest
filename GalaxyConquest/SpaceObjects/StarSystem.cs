﻿using System;
using System.Drawing;
using System.Collections.Generic;

using GalaxyConquest.StarSystems;

namespace GalaxyConquest
{
    /// <summary>
    /// Представляет звездную системы
    /// </summary>
    [Serializable]
    public class StarSystem : SpaceObject
    {
        /// <summary>
        /// Угловая скорость планеты
        /// </summary>
        public double angVel = 0.05;

        public double R = 0, timeOffset = 0, increment = 0;//Радиус движения системы, смещение фазы и смещение координат
        /// <summary>
        /// Тип звезды
        /// </summary>
        public int type;
        /// <summary>
        /// Браш, в виде которого планета будет представлена на экране
        /// </summary>
        public SolidBrush br;
        /// <summary>
        /// Количество планет (спорно)
        /// </summary>
        public int planets_count;
        /// <summary>
        /// Флаг, показывающий открыта ли система
        /// </summary>
        public bool Discovered = false;
        /// <summary>
        /// Планеты в звездной системе
        /// </summary>
        public List<Planet> planets = new List<Planet>();

        public override void Move(double time)
        {
            for (int i = 0; i < planets.Count; i++)
                planets[i].Move(time);
        }
    }
}
