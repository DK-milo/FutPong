using UnityEngine;

namespace FutPong
{
    public class InputMouse : InputHandler
    {
        [SerializeField] private float _sensitivity = 1.0f;

        public override float GetVerticalInput()
        {
            return Input.GetAxis("Mouse Y") * _sensitivity;
        }
    }
}
