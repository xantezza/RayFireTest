using UnityEngine;

namespace Assets.Scripts.InputProcessors
{
    internal class MoveCamera : InputProcessor
    {
        [SerializeField] private Transform CameraPivot;
        [SerializeField] private float _speed = 0.25f;
        private float previousPosition;

        public override void ProcessInput()
        {
            if (Input.GetMouseButton(0))
            {
                CameraPivot.eulerAngles += new Vector3(
                    0,
                         Input.mousePosition.x - previousPosition,
                    0) * _speed;
            }
            previousPosition = Input.mousePosition.x;
        }
    }
}