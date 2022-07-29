using UnityEngine;

namespace Control
{
    [CreateAssetMenu(fileName = "TailsFlySettings", menuName = "Tails/TailsFlySettings", order = 0)]
    public class TailsFlySettings : ScriptableObject
    {
        public float Speed;
    }
}