using System.Collections;
using UnityEngine;

namespace FutPong
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private Vector2 _ballDirection;
        [SerializeField, Range(1.0f, 50.0f)] private float _speed = 1.0f;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody2D>();
            _ballDirection = new Vector2(Random.Range(0, 2) * 2 - 1, 0);
            _rb.velocity = _ballDirection * _speed;
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            if (!col.collider.CompareTag("Player")) return;
            Vector2 velocity;
            velocity.x = _rb.velocity.x;
            velocity.y = _rb.velocity.y / 2 + col.collider.attachedRigidbody.velocity.y / 3;
            _rb.velocity = velocity;
        }

        public void Restart()
        {
            StartCoroutine(IERestart());
        }

        public IEnumerator IERestart()
        {
            _rb.velocity = Vector2.zero;
            _rb.transform.position = Vector2.zero;

            yield return new WaitForSeconds(1.0f);

            _ballDirection = new Vector2(Random.Range(0, 2) * 2 - 1, 0);

            _rb.velocity = _ballDirection * _speed;
        }
    }
}
