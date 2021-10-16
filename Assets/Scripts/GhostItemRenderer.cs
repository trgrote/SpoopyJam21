using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostItemRenderer : MonoBehaviour
{
    [SerializeField] private Models.Ghost _ghost;

    public void SetGhost(Models.Ghost ghost)
    {
        _ghost = ghost;

        var text = GetComponent<Text>();
        if (_ghost)
        {
            text.text = _ghost.Name;
        }
    }
}
