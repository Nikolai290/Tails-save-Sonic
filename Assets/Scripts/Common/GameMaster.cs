using System;
using UnityEngine;

namespace Common
{
    public class GameMaster : MonoBehaviour
    {
        private static GameSession _session;

        public void Awake()
        {
            StartGame();
        }

        private void StartGame()
        {
            _session = new GameSession();
        }

        public static bool IsAlive => _session.IsAlive;
        public static int PlayerHealth => _session.PlayerHealth;
        public static bool IsPaused => _session.Pause;
    }
}