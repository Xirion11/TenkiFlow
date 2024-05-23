using Interfaces;
using Systems;
using UnityEngine;

namespace Controllers
{
    public class PiecePreviewController : IPiecePreviewController
    {
        private ArtPiece _data; 
        private PopupEvent _onShowPopup;
        private RectTransform _previewRect;
        private RectTransform _parent;
        
        public void Setup(RectTransform previewRect, RectTransform parent, PopupEvent evt, ArtPiece data)
        {
            _data = data;
            _onShowPopup = evt;
            _parent = parent;
            _previewRect = previewRect;
        }

        public void OpenPopup()
        {
            _onShowPopup.Invoke(_data);
        }

        public Vector2 GetRandomPositionWithinParent()
        {
            var rect = _parent.rect;
            var previewRect = _previewRect.rect;
            var parentPosition = _parent.position;
            
            float minX = rect.x - (rect.width * 0.5f) + (previewRect.width * 0.5f);
            float maxX = rect.x + (rect.width * 0.5f) - (previewRect.width * 0.5f);
            float minY = rect.y - (rect.height * 0.5f) + (previewRect.height * 0.5f);
            float maxY = rect.y + (rect.height * 0.5f) - (previewRect.height * 0.5f);
        
            float randomX = Random.Range(minX, maxX) + rect.x + rect.width + parentPosition.x;
            float randomY = Random.Range(minY, maxY) + rect.y + rect.height + parentPosition.y;
            
            return new Vector2(randomX, randomY);
        }
    }
}
