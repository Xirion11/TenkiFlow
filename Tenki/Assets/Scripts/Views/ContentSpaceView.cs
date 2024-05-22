using System;
using Controllers;
using Interfaces;
using Systems;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class ContentSpaceView : MonoBehaviour
    {
        [SerializeField] private GameObject _viewContent = default;
        [SerializeField] private Button _btnBack = default;
        [SerializeField] private TextMeshProUGUI _txtTitle = default;
        [SerializeField] private Transform _piecesContent = default;
        [SerializeField] private PiecePreviewView _piecePreviewPrefab = default;
        [SerializeField] private Button _btnShuffle = default;
        [SerializeField] private UIEvent _onBackToHome = default;

        private IContentSpaceController _controller;

        [SerializeField] private PiecePreviewPool _previewPool;

        private void Awake()
        {
            _controller = new ContentSpaceController();
            _controller.Setup(this, _previewPool);
            
            _btnBack.onClick.AddListener(OnBackButton);
            _btnShuffle.onClick.AddListener(OnShuffleButton);
        }
        
        private void OnShuffleButton()
        {
            throw new NotImplementedException();
        }

        private void OnBackButton()
        {
            _onBackToHome.Invoke(null);
        }

        public void SetVisibility(bool visible)
        {
            _viewContent.SetActive(visible);
        }

        public void Setup(Space space)
        {
            _txtTitle.SetText(space.Name);
            _controller.ClearLayout();
            _controller.CreateLayout(_piecesContent, space, _piecePreviewPrefab);
        }
    }
}
