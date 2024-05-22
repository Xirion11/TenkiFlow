using Interfaces;
using Systems;
using UnityEngine;
using Views;

namespace Controllers
{
    public class SpacePreviewController : ISpacePreviewController
    {
        private SpacePreviewView _view;
        private Space _space;
        private UIEvent _onSpaceSelected;
        
        public void Setup(SpacePreviewView view, UIEvent onSpaceSelected)
        {
            _view = view;
            _onSpaceSelected = onSpaceSelected;
        }

        public void CreateLayout(Transform transform, Space space, PiecePreviewView piecePreviewPrefab)
        {
            _space = space;
            foreach (var artPiece in space.ArtPieces)
            {
                PiecePreviewView previewView = GameObject.Instantiate(piecePreviewPrefab, transform);

                if (artPiece.Art == null)
                {
                    previewView.SetupWithColor(artPiece, false);
                }
                else
                {
                    previewView.SetupWithSprite(artPiece, false);
                }
            }
        }

        public void OnSpaceButton()
        {
            _onSpaceSelected.Invoke(_space);
        }
    }
}
