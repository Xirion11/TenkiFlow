using System;
using Systems;
using UnityEngine;
using UnityEngine.Events;
using Views;

namespace Interfaces
{
    public interface ISpacePreviewController
    {
        public void Setup(UIEvent onSpaceSelected);
        public void CreateLayout(RectTransform transform, Space space, PiecePreviewView piecePreviewPrefab, UnityAction callback);
        public void OnSpaceButton();
    }
}
