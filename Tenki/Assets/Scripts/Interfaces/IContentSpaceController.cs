using Systems;
using UnityEngine;
using Views;

namespace Interfaces
{
    public interface IContentSpaceController
    {
        public void Setup(PiecePreviewPool pool);
        public void ClearLayout();
        public void CreateLayout(Transform transform, Space space);
        public void Shuffle();
    }
}
