using UnityEngine;

namespace FutPong
{
    public class KeyMapper : MonoBehaviour
    {
        [SerializeField] private InputKey _player1InputKey = null;
        [SerializeField] private InputKey _player2InputKey = null;
        private bool _isSetting;
        private int _buttonIndex;
        
        private void OnGUI()
        {
            if (!_isSetting) return;

            Event e = Event.current;

            if (!e.isKey || e.keyCode == KeyCode.None) return;

            switch (_buttonIndex)
            {
                case 0:
                    _player1InputKey.SetKeyUp(e.keyCode);
                    break;
                case 1:
                    _player1InputKey.SetKeyDown(e.keyCode);
                    break;
                case 2:
                    _player2InputKey.SetKeyUp(e.keyCode);
                    break;
                case 3:
                    _player2InputKey.SetKeyDown(e.keyCode);
                    break;
            }

            _isSetting = false;
        }
        public void SetKeyCode(int buttonIndex)
        {
            _isSetting = true;
            _buttonIndex = buttonIndex;
        }
    }
}
