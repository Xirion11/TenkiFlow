using Interfaces;
using Systems;
using UnityEngine;

namespace Controllers
{
    public class PiecePreviewController : IPiecePreviewController
    {
        private ArtPiece _data; 
        private PopupEvent _onShowPopup;
        
        public void Setup(PopupEvent evt, ArtPiece data)
        {
            _data = data;
            _onShowPopup = evt;
        }

        public void OpenPopup()
        {
            _onShowPopup.Invoke(_data);
        }
    }
}
