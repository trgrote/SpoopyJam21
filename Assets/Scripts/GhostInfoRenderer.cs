using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostInfoRenderer : MonoBehaviour
{
    [SerializeField] private Text _text;

    [SerializeField] private ExtGhostRef _highlightedGhost;

    void OnEnable()
    {
        _highlightedGhost.Changed += UpdateText;
    }

    void OnDisable()
    {
        _highlightedGhost.Changed -= UpdateText;
    }

    void UpdateText(rho.ExternalVariable<Models.Ghost> ghost, Models.Ghost oldGhost, Models.Ghost newGhost)
    {        
        _text.text = newGhost.Name;
    }
}
