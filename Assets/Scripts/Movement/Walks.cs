﻿using Constants;
using Enums;
using UnityEngine;

namespace Movement
{
    public class Walks:MonoBehaviour
    {
        protected SpriteOrientation _currentSpriteOrientation;
        // The GameObject that holds all the sprite renderer components
        private Transform _spriteContainer;
        private Rigidbody2D _rigidBody2D;


        public SpriteOrientation initialSpriteOrientation;

        protected void SetSpriteOrientation(SpriteOrientation spriteOrientation)
        {
            _currentSpriteOrientation = spriteOrientation;
            
            var shouldBeFlipped = spriteOrientation != initialSpriteOrientation;
            if (_spriteContainer != null)
            {
                // Scale on the x axis in the appropriate direction
                _spriteContainer.localScale = new Vector3(shouldBeFlipped ? -1 : 1, 1, 1);
            }
        }
        
        virtual protected void Start()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
            _currentSpriteOrientation = initialSpriteOrientation;
            foreach (Transform child in transform)
            {
                if (child.CompareTag(Tags.SpriteContainerTag))
                {
                    _spriteContainer = child;
                }
            }
        }

        protected void SetVelocity(Vector3 velocity)
        {
            _rigidBody2D.velocity = velocity;
        }

        public Vector3 GetVelocity()
        {
            return _rigidBody2D.velocity;
        }

        protected Vector2 GetPosition()
        {
            return _rigidBody2D.position;
        }
    }
}