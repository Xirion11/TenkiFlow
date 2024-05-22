using Interfaces;
using UnityEngine;
using Views;

namespace Controllers
{
    public class ContentSpaceController : IContentSpaceController
    {
        private ContentSpaceView _view;
        public void Setup(ContentSpaceView view)
        {
            _view = view;
        }

        public void ClearLayout()
        {
            throw new System.NotImplementedException();
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
