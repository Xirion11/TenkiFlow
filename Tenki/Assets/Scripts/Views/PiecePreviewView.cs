using System;
using System.Collections;
using System.Collections.Generic;
using Controllers;
using Interfaces;
using Systems;
using UnityEngine;
using UnityEngine.UI;

public class PiecePreviewView : MonoBehaviour
{
    [SerializeField] private Image _image = default;
    [SerializeField] private Sprite _defaultSprite = default;
    [SerializeField] private Button _btnOpenPopup = default;
    [SerializeField] private PopupEvent _onOpenPopup = default;
    
    private Transform _transform;
    private IPiecePreviewController _controller;
    
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

    private IPiecePreviewController Controller
    {
        get
        {
            if(_controller == null)
            {
                _controller = new PiecePreviewController();
            }

            return _controller;
        }
    }

    private void OnEnable()
    {
        _btnOpenPopup.onClick.AddListener(Controller.OpenPopup);
    }

    private void OnDisable()
    {
        _btnOpenPopup.onClick.RemoveListener(Controller.OpenPopup);
    }

    public void SetupWithSprite(ArtPiece data, bool enableButton)
    {
        Controller.Setup(_onOpenPopup, data);
        _image.sprite = data.Art;
        _image.color = Color.white;
        _btnOpenPopup.enabled = enableButton;
    }

    public void SetupWithColor(ArtPiece data, bool enableButton)
    {
        Controller.Setup(_onOpenPopup, data);
        _image.sprite = _defaultSprite;
        _image.color = data.Color;
        _btnOpenPopup.enabled = enableButton;
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
