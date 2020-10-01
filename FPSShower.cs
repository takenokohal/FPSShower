using System.Globalization;
using UnityEngine;

namespace Takenokohal.System
{
    public class FPSShower : MonoBehaviour
    {
        private const float Interval = 1f;

        private float _timeCounter;

        private float _frameCounter;

        private float _currentFps;


        private void Update()
        {
            _timeCounter += Time.deltaTime;
            _frameCounter++;

            if (_timeCounter < Interval)
                return;

            _currentFps = _frameCounter / _timeCounter;
            _frameCounter = 0;
            _timeCounter = 0;
        }

        private void OnGUI()
        {
            GUI.Label(
                new Rect(),
                _currentFps.ToString(CultureInfo.InvariantCulture) + "fps",
                new GUIStyle {fontSize = 50});
        }
    }
}