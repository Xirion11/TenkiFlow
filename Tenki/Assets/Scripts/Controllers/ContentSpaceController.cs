using System.Collections.Generic;
using Interfaces;
using Systems;
using UnityEngine;
using Views;

namespace Controllers
{
    public class ContentSpaceController : IContentSpaceController
    {
        private PiecePreviewPool _pool;
        private List<PiecePreviewView> _pooledPiecePreviews;

        private List<int> _indices;
        
        public void Setup(PiecePreviewPool pool)
        {
            _pool = pool;
            
            if (_pooledPiecePreviews == null)
            {
                _pooledPiecePreviews = new List<PiecePreviewView>();
            }

            if (_indices == null)
            {
                _indices = new List<int>();
            }
        }

        public void ClearLayout()
        {
            foreach (var pooledPiecePreview in _pooledPiecePreviews)
            {
                _pool.ReturnToPool(pooledPiecePreview);
            }
            _pooledPiecePreviews.Clear();
            _indices.Clear();
        }

        public void CreateLayout(RectTransform transform, Space space)
        {
            foreach (var artPiece in space.ArtPieces)
            {
                PiecePreviewView previewView = _pool.Get(transform);
                _pooledPiecePreviews.Add(previewView);
                previewView.SetAsLastSibling();

                if (artPiece.Art == null)
                {
                    previewView.SetupWithColor(transform, artPiece, true);
                }
                else
                {
                    previewView.SetupWithSprite(transform, artPiece, true);
                }
                
                _indices.Add(_indices.Count);
            }
        }

        public void Shuffle()
        {
            // _indices.Shuffle();
            
            for (int i = 0; i < _pooledPiecePreviews.Count; i++)
            {
                //_pooledPiecePreviews[i].SetSiblingIndex(_indices[i]);
                _pooledPiecePreviews[i].GetRandomPositionWithinParent();
            }
        }
    }
}