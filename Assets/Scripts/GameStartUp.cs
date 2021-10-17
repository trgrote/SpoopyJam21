using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartUp : MonoBehaviour
{
    [SerializeField] GhostRuntimeSet _ghosts;
    [SerializeField] int _startNumGhosts = 4;
    private float _prefixChance = 0.1f;
    private float _firstNameChance = 1f;
    private float _lastNameChance = 0.8f;
    private float _sufffixChance = 0.1f;

    public Repository.GhostNameRepository _ghostNames;

    public Repository.PackageRepository _packages;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < _startNumGhosts; ++i)
        {
            _ghosts.Add(RandomGhostGenerators.NewGhost(
                _packages.Packages,
                _ghostNames.Names,
                _prefixChance,
                _firstNameChance,
                _lastNameChance,
                _sufffixChance
            ));
        }
    }
}
