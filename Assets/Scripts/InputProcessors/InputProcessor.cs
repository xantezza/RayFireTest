using UnityEngine;

namespace Assets.Scripts.InputProcessors
{
    internal abstract class InputProcessor : MonoBehaviour
    {
        public abstract void ProcessInput();
    }
}