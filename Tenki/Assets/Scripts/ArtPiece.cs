using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArtPiece_New", menuName = "Art Piece")]
public class ArtPiece : ScriptableObject
{
    public string Description;
    public Sprite Art;
    public Color Color;
}
