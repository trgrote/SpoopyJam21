using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartUp : MonoBehaviour
{
    [SerializeField] GhostRuntimeSet _ghosts;
    [SerializeField] int _startNumGhosts = 4;
    [SerializeField] Models.GhostGeneratorConfig _generator;
    [SerializeField] private GhostRuntimeSet _missionGhosts;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _startNumGhosts; ++i)
        {
            _ghosts.Add(_generator.NewGhost());
        }

        _missionGhosts.Clear();
    }
}
