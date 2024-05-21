using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiecePreviewView : MonoBehaviour
{
    [SerializeField] private Image _image = default;
    public void Setup(Sprite sprite)
    {
        _image.sprite = sprite;
        _image.color = Color.white;
    }

    public void Setup(Color color)
    {
        _image.sprite = null;
        _image.color = color;
    }
}
