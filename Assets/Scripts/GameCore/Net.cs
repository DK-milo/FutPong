using UnityEngine;
using UnityEngine.Events;

namespace FutPong
{
    public class Net : MonoBehaviour, IScore
    {
        [SerializeField] private int _netId;
        public int GoalsReceived { get; private set; }
        public UnityEvent OnScore;
        public UnityEvent<Net> UpdateHUD;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Ball"))
            {
                Score();
            }
        }
        public void Score()
        {
            GoalsReceived++;
            OnScore.Invoke();
            UpdateHUD.Invoke(this);
        }
    }
}
