using UnityEngine;

namespace FutPong
{
    public class InputKey : InputHandler
    {
        [SerializeField] private KeyCode _keyUp = KeyCode.None;
        [SerializeField] private KeyCode _keyDown = KeyCode.None;

        public void SetKeyUp(KeyCode keyCode)
        {
            _keyUp = keyCode;
        }

        public void SetKeyDown(KeyCode keyCode)
        {
            _keyDown = keyCode;
        }

        public override float GetVerticalInput()
        {
            if (Input.GetKey(_keyUp))
            {
                return 1;
            }

            if (Input.GetKey(_keyDown))
            {
                return -1;
            }

            return 0;
        }
    }
}
