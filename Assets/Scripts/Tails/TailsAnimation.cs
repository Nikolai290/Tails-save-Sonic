using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Tails
{
    public class TailsAnimation : MonoBehaviour
    {
        public TailsAnimationSettings Settings;

        private void Update()
        {
            var rotate = new Vector3(0, 0, 1);
            transform.Rotate(
                rotate,
                Time.deltaTime * Settings.RotationSpeed
            );
        }
    }
}