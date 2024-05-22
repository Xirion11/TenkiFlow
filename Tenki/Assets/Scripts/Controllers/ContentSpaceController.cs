using System;
using System.Collections.Generic;
using Interfaces;
using Systems;
using UnityEngine;
using Views;

namespace Controllers
{
    public class ContentSpaceController : IContentSpaceController
    {
        private ContentSpaceView _view;
        private PiecePreviewPool _pool;
        private List<PiecePreviewView> _pooledPiecePreviews;
        
        public void Setup(ContentSpaceView view, PiecePreviewPool pool)
        {
            _view = view;
            _pool = pool;
            _pooledPiecePreviews = new List<PiecePreviewView>();
        }

        public void ClearLayout()
        {
            foreach (var pooledPiecePreview in _pooledPiecePreviews)
            {
                _pool.ReturnToPool(pooledPiecePreview);
            }
        }

        public void CreateLayout(Transform transform, Space space, PiecePreviewView piecePreviewPrefab)
        {
            foreach (var artPiece in space.ArtPieces)
            {
                PiecePreviewView previewView = _pool.Get(transform);//GameObject.Instantiate(piecePreviewPrefab, transform);
                _pooledPiecePreviews.Add(previewView);

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
