using Unity.VisualScripting;
using UnityEngine;

namespace Shooting
{
    public class GunCharacteristics
    {
        public GunSetting GunSetting { get; private set; }
        public int Projectiles { get; private set; }
        public int Damage { get; private set; }
        public float Speed { get; private set; }
        public float RateOfFire { get; private set; }
        public int Level { get; private set; }

        public GameObject ProjectilePrefab => GunSetting.ProjectilePrefab;

        public Vector3[] GetGoals(Vector3 centralGoal)
        {
            var goals = new Vector3[Projectiles];
            goals[0] = centralGoal;

            return goals;
        }

        public GunCharacteristics(GunSetting newGun)
        {
            ChangeGun(newGun);
        }

        public void ChangeGun(GunSetting newGun)
        {
            GunSetting = newGun;
            Projectiles = newGun.Projectiles;
            Damage = newGun.Damage;
            Speed = newGun.Speed;
            RateOfFire = newGun.RateOfFire;
            Level = 0;
        }

        public void LevelUp()
        {
            if (Level >= GunSetting.MaxLevel)
            {
                return;
            }
            SetLevel(Level+1);
        }

        private void SetLevel(int level = 0)
        {
            if (level < 1 || level > GunSetting.MaxLevel)
            {
                return;
            }

            Projectiles = Projectiles < GunSetting.MaxProjectiles
                ? Projectiles + GunSetting.StepProjectiles * level
                : Projectiles;
            Speed = LevelUp(
                GunSetting.Speed, 
                GunSetting.MaxSpeed,
                level, 
                GunSetting.MaxLevel);
            RateOfFire = LevelUp(
                GunSetting.RateOfFire, 
                GunSetting.MaxRateOfFire,
                level, 
                GunSetting.MaxLevel);
            Damage = (int)LevelUp(
                GunSetting.Damage,
                GunSetting.MaxDamage,
                level,
                GunSetting.MaxLevel);
        }

        private static int LevelUpProjectiles(int minValue, int maxValue, int step, int level, int maxLevel)
        {
            var value = level > 0
                ? minValue + step * level 
                : minValue;
            if (value > maxValue)
            {
                return maxValue;
            }
            return value;
        }

        private static float LevelUp(float minValue, float maxValue, int level, int maxLevel)
        {
            float step = (maxValue - minValue) / maxLevel;
            var value = minValue + step * level;
            return value;
        }
    }
}