using UnityEngine;

namespace FutPong
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private PlayerController[] _players = null;
        [SerializeField] private Ball _ball = null;

        private void Awake()
        {
            Net.onScore += Score;
            Time.timeScale = 0.0f;
        }
        
        #region Events

        public void Score()
        {
            Restart();
        }

        #endregion

        public void Restart()
        {
            foreach (PlayerController playerInput in _players)
            {
                playerInput.Restart();
            }

            _ball.Restart();
        }
    }
}
