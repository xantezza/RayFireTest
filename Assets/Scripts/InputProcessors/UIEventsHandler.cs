using RayFire;
using UnityEngine;

namespace Assets.Scripts.InputProcessors
{
    internal class UIEventsHandler : MonoBehaviour
    {
        [SerializeField] private InputProcessorUpdater _inputProcessorUpdater;
        [SerializeField] private GameObject _cubePrefab;

        public void OnResetPressed()
        {
            var a = FindObjectOfType<RayfireRigid>();
            if (a != null) Destroy(a.gameObject);
            var b = FindObjectOfType<RayfireMan>();
            if (b != null) Destroy(b.gameObject);

            Instantiate(_cubePrefab, Vector3.up, Quaternion.identity);
        }

        public void OnToggled(InputProcessor inputProcessorMode)
        {
            _inputProcessorUpdater.InputProcessor = inputProcessorMode;
        }
    }
}