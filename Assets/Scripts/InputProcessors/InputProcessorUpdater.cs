using UnityEngine;

namespace Assets.Scripts.InputProcessors
{
    internal class InputProcessorUpdater : MonoBehaviour
    {
        [SerializeField] private InputProcessor _startupMode;
        internal InputProcessor InputProcessor;

        private void Start()
        {
            InputProcessor = _startupMode;
        }

        private void Update()
        {
            InputProcessor.ProcessInput();
        }
    }
}