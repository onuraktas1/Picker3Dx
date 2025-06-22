using UnityEngine;
using UnityEngine.Events;

namespace RunTime.Signals
{
    public class CameraSignals : MonoBehaviour
    {
        public static CameraSignals Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
                return;
            }

            Instance = this;
        }

        public UnityAction onSetCameraTarget = delegate { };
    }
}