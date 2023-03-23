using UnityEngine;

namespace FutPong
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private InputHandler _inputHandler = null;
        [SerializeField, Range(250.0f, 500.0f)] private float _movementSpeed = 500.0f;

        private void FixedUpdate()
        {
            CharacterMovement();
        }

        private void CharacterMovement()
        {
            float inputVertical = _inputHandler.GetVerticalInput();

            Vector2 direction = new Vector2(0, inputVertical);
            GetComponent<Rigidbody2D>().velocity = direction * _movementSpeed * Time.deltaTime;
        }
    }
}
