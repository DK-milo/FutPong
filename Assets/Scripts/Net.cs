using UnityEngine;
using UnityEngine.Events;

namespace FutPong
{
    public class Net : MonoBehaviour
    {
        [SerializeField] private int _idNet = 0;
        public UnityEvent<int> OnGoal; 

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Ball"))
            {
                OnGoal.Invoke(_idNet);
            }
        }
    }
}
