using UnityEngine;

namespace CameraN
{
    [CreateAssetMenu(fileName = "CameraSettings", menuName = "Tails/Camera settings", order = 0)]
    public class CameraSettings : ScriptableObject
    {
        public float Speed;
    }
}