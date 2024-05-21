using Controllers;
using Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class SpacePreviewView : MonoBehaviour
    {
        [SerializeField] private Button _spaceButton = default;
        [SerializeField] private TextMeshProUGUI _title = default;
        [SerializeField] private Transform _pieceContainer = default;
        [SerializeField] private PiecePreviewView _piecePreviewPrefab = default;
        [SerializeField] private UIEvent _onSpaceSelected = default;
    
        private ISpacePreviewController _controller;
    
        private void Awake()
        {
            _controller = new SpacePreviewController();
            _controller.Setup(this, _onSpaceSelected);
            _spaceButton.onClick.AddListener(OnSpaceButton);
        }

        public void Setup(Space space)
        {
            _title.SetText(space.Name);

            _controller.CreateLayout(_pieceContainer, space, _piecePreviewPrefab);
        }
        
        private void OnSpaceButton()
        {
            _controller.OnSpaceButton();
        }
    }
}
