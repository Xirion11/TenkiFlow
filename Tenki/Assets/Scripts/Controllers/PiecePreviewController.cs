using Interfaces;
using Systems;
using UnityEngine;

namespace Controllers
{
    public class PiecePreviewController : IPiecePreviewController
    {
        private ArtPiece _data; 
        private UIEvent _onShowPopup;
        
        public void SetData(ArtPiece data)
        {
            _data = data;
        }

        public void OpenPopup()
        {
            //_onShowPopup.Invoke(_data);
        }
    }
}
