using System;
using UnityEngine;

namespace Shooting
{
    public class ProjectileBehaviour : MonoBehaviour
    {
        private int Damage;
        private float Lifetime;
        private float Speed;

        private DateTime _birthday;
        private DateTime _die;

        private bool _ready;

        public void Awake()
        {
            _birthday = DateTime.Now;
        }

        public void Init(int damage, float lifetime, float speed)
        {
            Damage = damage;
            Lifetime = lifetime;
            Speed = speed;
            _die = _birthday.AddSeconds(lifetime);
            _ready = true;
        }
        
        private void Update()
        {
            if (DateTime.Now >= _die)
            {
                Destroy(gameObject);
            }

            if (!_ready)
            {
                return;
            }

            var target = transform.position + Vector3.up;
            
            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                Speed * Time.deltaTime);
        }
    }
}