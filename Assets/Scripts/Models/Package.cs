using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    [CreateAssetMenu(fileName = "NewPackage", menuName = "Models/New Package")]
    public class Package : ScriptableObject
    {
        public string Name;
        public List<Attribute> Attributes;
    }
}