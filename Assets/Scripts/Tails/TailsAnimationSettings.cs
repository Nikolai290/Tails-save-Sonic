using UnityEngine;

namespace Tails
{
    [CreateAssetMenu(fileName = "Tails animation settings", menuName = "Tails/Tails animation settings", order = 0)]
    public class TailsAnimationSettings : ScriptableObject
    {
        public float RotationSpeed;
    }
}