using UnityEngine;

namespace Interfaces
{
    public interface ISpacePreviewController
    {
        public void Setup(SpacePreviewView view);
        public void CreateLayout(Transform transform, Space space, PiecePreviewView piecePreviewPrefab);
    }
}
