using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    [CreateAssetMenu(fileName = "NewGhostName", menuName = "Models/New Ghost Name")]
    public class GhostName : ScriptableObject
    {
        public string Name;
        public bool Prefix, FirstName, LastName, Suffix;
    }
}