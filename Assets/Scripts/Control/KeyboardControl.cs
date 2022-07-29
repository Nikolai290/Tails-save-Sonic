using UnityEngine;

namespace Control
{
    public class KeyboardControl : MonoBehaviour
    {
        [SerializeField] private ScreenBordersSetting _screenBordersSetting;
        [SerializeField] private TailsFlySettings _tailsFlySettings;

        private float _horizontal = 0f;
        private float _vertical = 0f;
        
        private void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
            var vector = new Vector2(_horizontal, _vertical);

            
            if (vector != Vector2.zero)
            {
                var target = new Vector2(
                    transform.position.x + _horizontal, 
                    transform.position.y + _vertical);
                target = Utilites.CheckBorders(target, _screenBordersSetting, Camera.main.transform.position);
                transform.position = Vector2.MoveTowards(
                    transform.position,
                    target,
                    _tailsFlySettings.Speed * Time.deltaTime
                );
            }
        }
    }
}