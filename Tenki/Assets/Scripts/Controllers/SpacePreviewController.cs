using System;
using Interfaces;
using Systems;
using UnityEngine;
using UnityEngine.Events;
using Views;

namespace Controllers
{
    public class SpacePreviewController : ISpacePreviewController
    {
        private Space _space;
        private UIEvent _onSpaceSelected;
        
        public void Setup(UIEvent onSpaceSelected)
        {
            _onSpaceSelected = onSpaceSelected;
        }

        public void CreateLayout(RectTransform transform, Space space, PiecePreviewView piecePreviewPrefab, UnityAction callback)
        {
            _space = space;
            foreach (var artPiece in space.ArtPieces)
            {
                PiecePreviewView previewView = GameObject.Instantiate(piecePreviewPrefab, transform);

                if (artPiece.Art == null)
                {
                    previewView.SetupWithColor(transform, artPiece, true, callback); //TODO: Remove enable button, will always be true
                }
                else
                {
                    previewView.SetupWithSprite(transform, artPiece, true, callback);
                }
            }
        }

        public void OnSpaceButton()
        {
            _onSpaceSelected.Invoke(_space);
        }
    }
}
