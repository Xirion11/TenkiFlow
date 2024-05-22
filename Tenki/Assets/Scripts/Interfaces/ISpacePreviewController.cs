using Systems;
using UnityEngine;
using Views;

namespace Interfaces
{
    public interface ISpacePreviewController
    {
        public void Setup(UIEvent onSpaceSelected);
        public void CreateLayout(Transform transform, Space space, PiecePreviewView piecePreviewPrefab);
        public void OnSpaceButton();
    }
}
