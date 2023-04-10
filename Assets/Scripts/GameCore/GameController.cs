using UnityEngine;

namespace FutPong
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private PlayerInput[] _players = null;
        [SerializeField] private Ball _ball = null;

        private void Awake()
        {
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
            foreach (PlayerInput playerInput in _players)
            {
                playerInput.Restart();
            }

            _ball.Restart();
        }
    }
}
