using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionInfoRenderer : MonoBehaviour
{
    [SerializeField] Text _text;
    
    [SerializeField] private GhostRuntimeSet _missionGhosts;

    void OnEnable()
    {
        _missionGhosts.SetChanged += UpdateText;
    }

    void OnDisable()
    {
        _missionGhosts.SetChanged -= UpdateText;
    }

    // Update is called once per frame
    void UpdateText(rho.RuntimeSet<Models.Ghost> set)
    {
        _text.text = $"Selected Ghost: {set.Count} / 2";
    }
}
