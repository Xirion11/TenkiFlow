using Controllers;
using Interfaces;
using Systems;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class PopupView : MonoBehaviour
    {
        [SerializeField] private Image _art = default;
        [SerializeField] private Sprite _defaultSprite = default;
        [SerializeField] private TextMeshProUGUI _description = default;
        [SerializeField] private Button _btnClosePopup = default;
        
        private PopupController _controller;

        private IPopupController Controller
        {
            get
            {
                if (_controller == null)
                {
                    _controller = new PopupController();
                }

                return _controller;
            }
        }
        
        public void Setup(ArtPiece data, PopupPool pool)
        {
            if (data.Art == null)
            {
                _art.sprite = _defaultSprite;
                _art.color = data.Color;
            }
            else
            {
                _art.sprite = data.Art;
                _art.color = Color.white;
            }
            
            _description.SetText(data.Description);
            
            Controller.Setup(this, pool);
        }

        private void OnEnable()
        {
            _btnClosePopup.onClick.AddListener(Controller.ClosePopup);
        }

        private void OnDisable()
        {
            _btnClosePopup.onClick.RemoveListener(Controller.ClosePopup);
        }
    }
}
