using Systems;
using UnityEngine;
using Views;

namespace Interfaces
{
    public interface IContentSpaceController
    {
        public void Setup(PiecePreviewPool pool);
        public void ClearLayout();
        public void CreateLayout(RectTransform panelContainer, RectTransform previewContainer, Space space);
        public void Shuffle();
    }
}
