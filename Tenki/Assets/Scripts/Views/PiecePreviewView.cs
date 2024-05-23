using System;
using Controllers;
using Interfaces;
using Systems;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Views
{
    public class PiecePreviewView : MonoBehaviour
    {
        [SerializeField] private Image _image = default;
        [SerializeField] private Sprite _defaultSprite = default;
        [SerializeField] private Button _btnOpenPopup = default;
        [SerializeField] private PopupEvent _onOpenPopup = default;
    
        private Transform _transform;
        private IPiecePreviewController _controller;
        private UnityAction _callback;
    
        private Transform Transform 
        {
            get
            {
                if(_transform == null)
                {
                    _transform = this.transform;
                }

                return _transform;
            }
        }

        private IPiecePreviewController Controller
        {
            get
            {
                if(_controller == null)
                {
                    _controller = new PiecePreviewController();
                }

                return _controller;
            }
        }
        
        private void OnEnable()
        {
            if(_callback != null)
            {
                _btnOpenPopup.onClick.RemoveAllListeners();
                _btnOpenPopup.onClick.AddListener(_callback);
            }
        }

        private void OnDisable()
        {
            _btnOpenPopup.onClick.RemoveListener(_callback);
        }

        public void SetupWithSprite(RectTransform parent, ArtPiece data, bool enableButton, UnityAction callback = null)
        {
            Controller.Setup(parent, _onOpenPopup, data);
            _image.sprite = data.Art;
            _image.color = Color.white;
            _btnOpenPopup.enabled = enableButton;
            _callback = callback ?? Controller.OpenPopup;
            _btnOpenPopup.onClick.RemoveAllListeners();
            _btnOpenPopup.onClick.AddListener(_callback);
        }

        public void SetupWithColor(RectTransform parent, ArtPiece data, bool enableButton, UnityAction callback = null)
        {
            Controller.Setup(parent, _onOpenPopup, data);
            _image.sprite = _defaultSprite;
            _image.color = data.Color;
            _btnOpenPopup.enabled = enableButton;
            _callback = callback ?? Controller.OpenPopup;
            _btnOpenPopup.onClick.RemoveAllListeners();
            _btnOpenPopup.onClick.AddListener(_callback);
        }

        public void SetSiblingIndex(int index)
        {
            Transform.SetSiblingIndex(index);
        }

        public void SetAsLastSibling()
        {
            Transform.SetAsLastSibling();
        }

        public void GetRandomPositionWithinParent()
        {
            _transform.position = Controller.GetRandomPositionWithinParent();
        }
    }
}
