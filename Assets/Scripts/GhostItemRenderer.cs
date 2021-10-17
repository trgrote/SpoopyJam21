using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostItemRenderer : MonoBehaviour
{
    private Models.Ghost _ghost;
    [SerializeField] private Text _text;

    [SerializeField] private ExtGhostRef _highlightedGhost;
    [SerializeField] private GhostRuntimeSet _missionGhosts;

    public void SetGhost(Models.Ghost ghost)
    {
        _ghost = ghost;

        _text.text = _ghost.Name;
    }

    public void SetAsHighlightedGhost()
    {
        _highlightedGhost.Value = _ghost;
    }

    public void OnGhostSelected(bool on)
    {
        if (on)
        {
            _missionGhosts.Add(_ghost);
        }
        else
        {
            _missionGhosts.Remove(_ghost);
        }
    }
}
