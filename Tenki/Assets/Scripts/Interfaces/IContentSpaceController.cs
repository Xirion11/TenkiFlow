using UnityEngine;
using Views;

namespace Interfaces
{
    public interface IContentSpaceController
    {
        public void Setup(ContentSpaceView view);
        public void CreateLayout(Transform transform, Space space, PiecePreviewView piecePreviewPrefab);
    }
}
