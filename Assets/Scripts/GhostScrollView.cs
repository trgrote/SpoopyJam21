using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GhostScrollView : MonoBehaviour
{
    [SerializeField] private GhostRuntimeSet _ghosts;
    [SerializeField] GameObject _itemPrefab;

    void OnEnable()
    {
        _ghosts.SetChanged += UpdateList;
    }

    void OnDisable()
    {
        _ghosts.SetChanged -= UpdateList;
    }

    void Start()
    {
        UpdateList(_ghosts);
    }

    public void UpdateList(rho.RuntimeSet<Models.Ghost> ghosts)
    {        
        // Kill all the children
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Repopulate with current list
        foreach (var ghost in ghosts)
        {
            Instantiate(_itemPrefab, transform);
        }
    }
}
