using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpaceView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _title = default;
    [SerializeField] private Transform _pieceContainer = default;
    [SerializeField] private PiecePreviewView _piecePreviewPrefab = default;
    public void Setup(Space space)
    {
        _title.SetText(space.Name);

        foreach (var artPiece in space.ArtPieces)
        {
            PiecePreviewView previewView = Instantiate(_piecePreviewPrefab, _pieceContainer);

            if (artPiece.Art == null)
            {
                previewView.Setup(artPiece.Color);
            }
            else
            {
                previewView.Setup(artPiece.Art);
            }
        }
    }
}
