using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpaceView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _title = default;
    public void Setup(Space space)
    {
        _title.SetText(space.Name);
    }
}
