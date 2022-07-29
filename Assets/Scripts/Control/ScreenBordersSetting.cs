using UnityEngine;

namespace Control
{
    [CreateAssetMenu(fileName = "ScreenBorderSettings", menuName = "Tails/ScreenBorderSettings", order = 0)]
    public class ScreenBordersSetting : ScriptableObject
    {
        public Vector2 MinBorder;
        public Vector2 MaxBorder;
    }
}