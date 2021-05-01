using System;
using IdleEngine.Sessions;
using UnityEngine;

namespace IdleEngine
{
    public class IdleEngineClass : MonoBehaviour
    {
        public Session idleSession;

        private void Update()
        {
            if (!idleSession)
            {
                return;
            }

            idleSession.Tick(Time.deltaTime);
        }

        private void OnEnable()
        {
            if (!idleSession)
            {
                return;
            }

            idleSession.CalculateOfflineProgression();
        }

        private void OnDisable()
        {
            if (!idleSession)
            {
                return;
            }

            idleSession.LastTicks = DateTime.UtcNow.Ticks;
        }
    }
}
