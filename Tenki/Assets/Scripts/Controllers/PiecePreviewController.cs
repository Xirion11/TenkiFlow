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
            float minX = 0;
            float maxX = Screen.width;
            float minY = 0;
            float maxY = Screen.height;
        
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            
            return new Vector2(randomX, randomY);
        }
    }
}
