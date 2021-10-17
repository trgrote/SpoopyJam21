using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    [System.Serializable]
    public class AttributeScorePair
    {
        public Attribute Attribute;
        public int Score;
    }

    [CreateAssetMenu(fileName = "NewPackage", menuName = "Models/New Package")]
    public class Package : ScriptableObject
    {
        public string Name;
        public List<AttributeScorePair> AttributeScores;
    }
}