using Systems;

namespace Interfaces
{
    public interface IPiecePreviewController
    {
        public void Setup(PopupEvent evt, ArtPiece data);
        public void OpenPopup();
    }
}
