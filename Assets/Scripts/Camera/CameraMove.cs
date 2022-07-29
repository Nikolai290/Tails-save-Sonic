using Common;
using UnityEngine;

namespace CameraN
{
    public class CameraMove : MonoBehaviour
    {
        [SerializeField] private CameraSettings Settings;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if (GameMaster.IsPaused
                || !GameMaster.IsAlive)
            {
                return;
            }

            var target = transform.position + Vector3.up;
            target.z = transform.position.z;

            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                Settings.Speed * Time.deltaTime);
        }
    }
}