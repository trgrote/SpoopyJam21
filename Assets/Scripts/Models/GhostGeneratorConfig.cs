using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    [CreateAssetMenu(fileName = "NewGhostGeneratorConfig", menuName = "Models/New Ghost Generator Config")]
    public class GhostGeneratorConfig : ScriptableObject
    {
        public float _prefixChance = 0.1f;
        public float _firstNameChance = 1f;
        public float _lastNameChance = 0.8f;
        public float _sufffixChance = 0.1f;

        public Repository.GhostNameRepository _ghostNames;

        public Repository.PackageRepository _packages;

        public Ghost NewGhost()
        {
            return RandomGhostGenerators.NewGhost(
                _packages.Packages,
                _ghostNames.Names,
                _prefixChance,
                _firstNameChance,
                _lastNameChance,
                _sufffixChance
            );
        }
    }
}