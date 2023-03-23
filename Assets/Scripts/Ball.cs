using UnityEngine;

namespace FutPong.Assets.Scripts
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private Vector2 _ballDirection;
        [SerializeField, Range(100.0f, 250.0f)] private float _speed = 250.0f;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _ballDirection = new Vector2(Random.Range(0, 2) * 2 - 1, Random.Range(0, 2) * 2 - 1);
            _rb.velocity = _ballDirection * _speed * Time.deltaTime;
        }
    }
}
