using Systems;
using UnityEngine;

namespace Interfaces
{
    public interface IPiecePreviewController
    {
        public void Setup(RectTransform previewRect, RectTransform parent, PopupEvent evt, ArtPiece data);
        public void OpenPopup();
        public Vector2 GetRandomPositionWithinParent();
    }
}
