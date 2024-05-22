using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiecePreviewView : MonoBehaviour
{
    [SerializeField] private Image _image = default;
    [SerializeField] private Sprite _defaultSprite = default;
    
    Transform _transform;
    
    private Transform Transform 
    {
        get
        {
            if(_transform == null)
            {
                _transform = this.transform;
            }

            return _transform;
        }
    }
    
    private void Awake()
    {
        _transform = this.transform;
    }
    
    public void Setup(Sprite sprite)
    {
        _image.sprite = sprite;
        _image.color = Color.white;
    }

    public void Setup(Color color)
    {
        _image.sprite = _defaultSprite;
        _image.color = color;
    }

    public void SetSiblingIndex(int index)
    {
        Transform.SetSiblingIndex(index);
    }

    public void SetAsLastSibling()
    {
        Transform.SetAsLastSibling();
    }
}
