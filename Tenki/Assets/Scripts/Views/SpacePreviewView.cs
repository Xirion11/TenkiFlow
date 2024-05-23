using Controllers;
using Interfaces;
using Systems;
using TMPro;
using UnityEngine;

namespace Views
{
    public class SpacePreviewView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _title = default;
        [SerializeField] private RectTransform _pieceContainer = default;
        [SerializeField] private PiecePreviewView _piecePreviewPrefab = default;
        [SerializeField] private UIEvent _onSpaceSelected = default;
    
        private ISpacePreviewController _controller;
    
        private void Awake()
        {
            _controller = new SpacePreviewController();
            _controller.Setup(_onSpaceSelected);
        }

        public void Setup(Space space)
        {
            _title.SetText(space.Name);

            _controller.CreateLayout(_pieceContainer, space, _piecePreviewPrefab, OnSpaceButton);
        }
        
        private void OnSpaceButton()
        {
            _controller.OnSpaceButton();
        }
    }
}
