using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomGhostNameGenerator : MonoBehaviour
{
    private float _prefixChance = 0.1f;
    private float _firstNameChance = 1f;
    private float _lastNameChance = 0.8f;
    private float _sufffixChance = 0.1f;

    public Repository.GhostNameRepository _ghostNames;

    public Repository.PackageRepository _packages;

    [NaughtyAttributes.Button]
    public void TestRandomName()
    {
        Debug.Log(RandomGhostGenerators.GenerateRandomName(
            _ghostNames.Names,
            _prefixChance,
            _firstNameChance,
            _lastNameChance,
            _sufffixChance
        ));
    }

    [NaughtyAttributes.Button]
    public void MakeRandomGhost()
    {
        Debug.Log(RandomGhostGenerators.NewGhost(
            _packages.Packages,
            _ghostNames.Names,
            _prefixChance,
            _firstNameChance,
            _lastNameChance,
            _sufffixChance
        ).Name);
    }
}
