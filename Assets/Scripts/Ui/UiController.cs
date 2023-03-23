using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace FutPong.Assets.Scripts
{
    public class UiController : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu = null;
        [SerializeField] private GameObject _startMenu = null;
        [SerializeField] private GameObject _menuSettings = null;

        [SerializeField] private TMP_Text _goalsPlayer1 = null;
        [SerializeField] private TMP_Text _goalsPlayer2 = null;

        public UnityEvent<bool> OnStartEvent;

        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Escape)) return;

            if (_mainMenu.activeInHierarchy == false)
            {
                OnStartEvent.Invoke(false);
                _mainMenu.SetActive(true);
            }

            if (_menuSettings.activeInHierarchy)
            {
                _menuSettings.SetActive(false);
                _startMenu.SetActive(true);
            }
        }

        public void ButtonStart()
        {
            _mainMenu.SetActive(false);
            OnStartEvent.Invoke(true);
        }

        public void ButtonSettings()
        {
            _startMenu.SetActive(false);
            _menuSettings.SetActive(true);
        }

        public void UpdateGoalsUi(int netId)
        {
            int tempScore;

            if (netId == 0)
            {
                tempScore = int.Parse(_goalsPlayer2.text) + 1;
                _goalsPlayer2.text = tempScore.ToString();
            }
            else
            {
                tempScore = int.Parse(_goalsPlayer1.text) + 1;
                _goalsPlayer1.text = tempScore.ToString();
            }
        }
    }
}
