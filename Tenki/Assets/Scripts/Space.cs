using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Space_New", menuName = "Space")]
public class Space : ScriptableObject
{
    public string Name;
    public ArtPiece[] ArtPieces;
}
