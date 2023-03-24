using UnityEngine;
using UnityEngine.Events;

namespace FutPong
{
    public class GameController : MonoBehaviour
    {
        private int _goalsPlayer1;
        private int _goalsPlayer2;

        [SerializeField] private PlayerInput[] _players = null;
        [SerializeField] private Ball _ball = null;

        public UnityEvent<int> UpdateHUD;

        private void Awake()
        {
            Time.timeScale = 0.0f;
        }

        #region Events
        public void StartGame(bool state)
        {
            Time.timeScale = state ? 1.0f : 0.0f;
        }

        public void Score(int idNet)
        {
            if (idNet == 0)
            {
                _goalsPlayer2++;
            }
            else
            {
                _goalsPlayer1++;
            }
            
            // Update the UI
            UpdateHUD.Invoke(idNet);

            Restart();
        }
        #endregion
        
        private void Restart()
        {
            foreach (PlayerInput playerInput in _players)
            {
                playerInput.Restart();
            }

            _ball.Restart();
        }
    }
}
