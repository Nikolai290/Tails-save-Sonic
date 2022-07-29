﻿using UnityEngine;

namespace Shooting
{
    public class ProjectileSpawner : MonoBehaviour
    {
        [SerializeField] private GunSetting BaseGun;
        [SerializeField] private Transform Trunk;
        [SerializeField] private Transform Goal;
        private GunCharacteristics _gunCharacteristics;

        public void Shoot()
        {
            var projectile = Instantiate(_gunCharacteristics.ProjectilePrefab, Trunk);
        }
        
        private void Awake()
        {
            _gunCharacteristics = new GunCharacteristics(BaseGun);
        }

        public void ChangeGun(GunSetting newGun)
        {
            _gunCharacteristics.ChangeGun(newGun);
        }

        public void LevelUp()
        {
            _gunCharacteristics.LevelUp();
        }
    }
}