using UnityEngine;
using UnityEngine.Events;

namespace FutPong
{
    public class GameController : MonoBehaviour
    {
        private int _goalsPlayer1;
        private int _goalsPlayer2;

        public UnityEvent<int> OnScore;

        private void Awake()
        {
            Time.timeScale = 0.0f;
        }

        #region Events
        public void StartGame(bool state)
        {
            Time.timeScale = state ? 1.0f : 0.0f;
        }

        public void AddGoal(int idNet)
        {
            if (idNet == 0)
            {
                _goalsPlayer2++;
            }
            else
            {
                _goalsPlayer1++;
            }

            OnScore.Invoke(idNet);
        }
        #endregion
    }
}
