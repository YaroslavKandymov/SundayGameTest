﻿

using UnityEngine;

namespace SundaygameTest.Other
{
    public class SurfaceSlider
    {
        private Vector3 _normal;

        public Vector3 Project(Vector3 direction)
        {
            return direction - Vector3.Dot(direction, _normal) * _normal;
        }
    }
}