﻿using Enums;
using UnityEngine;

namespace Movement
{
    public class Followable : Walks
    {
        public SpriteOrientation GetSpriteOrientation()
        {
            return _currentSpriteOrientation;
        }

        public float GetDistanceTo(Vector2 point)
        {
            return Vector2.Distance(point, GetPosition());
        }
    }
}
