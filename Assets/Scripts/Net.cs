using UnityEngine;
using UnityEngine.Events;

namespace FutPong
{
    public class Net : MonoBehaviour
    {
        [SerializeField] private int _idNet = 0;
        public UnityEvent<int> OnGoal; 

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ball"))
            {
                OnGoal.Invoke(_idNet);
            }
        }
    }
}
