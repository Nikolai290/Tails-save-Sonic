using UnityEngine;

namespace Control
{
    public class Utilites
    {
        public static Vector3 CheckBorders(Vector3 position, ScreenBordersSetting _screenBordersSetting, Vector3 cameraOffset) {
            
            
            var x = position.x > _screenBordersSetting.MaxBorder.x + cameraOffset.x
                ? _screenBordersSetting.MaxBorder.x + cameraOffset.x
                : position.x < _screenBordersSetting.MinBorder.x + cameraOffset.x
                    ? _screenBordersSetting.MinBorder.x + cameraOffset.x
                    : position.x;
            var y = position.y > _screenBordersSetting.MaxBorder.y + cameraOffset.y
                ? _screenBordersSetting.MaxBorder.y + cameraOffset.y
                : position.y < _screenBordersSetting.MinBorder.y + cameraOffset.y
                    ? _screenBordersSetting.MinBorder.y + cameraOffset.y
                    : position.y;

            return new Vector3(x, y, position.z);
        }
    }
}