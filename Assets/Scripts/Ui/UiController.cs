using TMPro;
using UnityEngine;

namespace FutPong
{
    public class UiController : MonoBehaviour
    {
        [SerializeField] private GameObject _mainMenu = null;
        [SerializeField] private GameObject _startMenu = null;
        [SerializeField] private GameObject _menuSettings = null;

        [SerializeField] private TMP_Text _goalsPlayer1 = null;
        [SerializeField] private TMP_Text _goalsPlayer2 = null;
        
        private void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Escape)) return;

            if (_mainMenu.activeInHierarchy == false)
            {
                Time.timeScale = 0.0f;
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
            Time.timeScale = 1.0f;
        }

        public void ButtonSettings()
        {
            _startMenu.SetActive(false);
            _menuSettings.SetActive(true);
        }
        
        public void UpdateGoalsPlayer1(Net net)
        {
            _goalsPlayer2.text = net.GoalsReceived.ToString();
        }
        public void UpdateGoalsPlayer2(Net net)
        {
            _goalsPlayer1.text = net.GoalsReceived.ToString();
        }
    }
}
