using System;
using UnityEngine;

namespace FutPong
{
    public class Net : MonoBehaviour, IScore
    {
        public int Id;
        public int GoalsReceived { get; private set; }
        public static Action onScore;
        public static Action<Net> updateHUD;

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
            onScore.Invoke();
            updateHUD?.Invoke(this);
        }
    }
}
