using Interfaces;
using UnityEngine;

namespace Controllers
{
    public class SpacePreviewController : ISpacePreviewController
    {
        private SpacePreviewView _view;
        
        public void Setup(SpacePreviewView view)
        {
            _view = view;
        }

        public void CreateLayout(Transform transform, Space space, PiecePreviewView piecePreviewPrefab)
        {
            foreach (var artPiece in space.ArtPieces)
            {
                PiecePreviewView previewView = GameObject.Instantiate(piecePreviewPrefab, transform);

                if (artPiece.Art == null)
                {
                    previewView.Setup(artPiece.Color);
                }
                else
                {
                    previewView.Setup(artPiece.Art);
                }
            }
        }
    }
}
