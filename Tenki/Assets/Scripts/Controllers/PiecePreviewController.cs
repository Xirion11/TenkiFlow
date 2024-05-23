using Interfaces;
using Systems;
using UnityEngine;

namespace Controllers
{
    public class PiecePreviewController : IPiecePreviewController
    {
        private ArtPiece _data; 
        private PopupEvent _onShowPopup;
        private RectTransform _parent;
        
        public void Setup(RectTransform parent, PopupEvent evt, ArtPiece data)
        {
            _data = data;
            _onShowPopup = evt;
            _parent = parent;
        }

        public void OpenPopup()
        {
            _onShowPopup.Invoke(_data);
        }

        public Vector2 GetRandomPositionWithinParent()
        {
            var rect = _parent.rect;
            // float minX = 0;
            // float maxX = rect.width;
            // float minY = 0;
            // float maxY = rect.height;
            
            // float minX = 0 + rect.center.x;
            // float maxX = rect.width + rect.center.x;
            // float minY = 0 + rect.center.y;
            // float maxY = rect.height + rect.center.y;
            
            // float minX = 0 + rect.center.x;
            // float maxX = rect.width + rect.center.x;
            // float minY = 0 + rect.center.y;
            // float maxY = rect.height + rect.center.y;
            
            // float minX = rect.center.x - rect.width * 0.5f;
            // float maxX = rect.center.x + rect.width * 0.5f;
            // float minY = rect.center.y - rect.height * 0.5f;
            // float maxY = rect.center.y + rect.height * 0.5f;
            
            float minX = rect.x - rect.width * 0.5f;
            float maxX = rect.x + rect.width * 0.5f;
            float minY = rect.y - rect.height * 0.5f;
            float maxY = rect.y + rect.height * 0.5f;
            
            // float minX = -rect.width * 0.5f;
            // float maxX = rect.width * 0.5f;
            // float minY = -rect.height * 0.5f;
            // float maxY = rect.height * 0.5f;
        
            float randomX = Random.Range(minX, maxX) + rect.x + rect.width;
            float randomY = Random.Range(minY, maxY) + rect.y + rect.height;

            var parentPosition = _parent.position;
            randomX += parentPosition.x;
            randomY += parentPosition.y;
            
            return new Vector2(randomX, randomY);
        }
    }
}
