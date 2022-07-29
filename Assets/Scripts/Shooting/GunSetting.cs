using UnityEngine;

namespace Shooting
{
    [CreateAssetMenu(fileName = "Gun_0", menuName = "Tails/Gun setting", order = 0)]
    public class GunSetting : ScriptableObject
    {
        public GameObject ProjectilePrefab;
        public int Projectiles;
        public int MaxProjectiles;
        public int StepProjectiles;
        public int Damage;
        public int MaxDamage;
        public float Speed;
        public float MaxSpeed;
        public float RateOfFire;
        public float MaxRateOfFire;
        public int MaxLevel;
    }
}