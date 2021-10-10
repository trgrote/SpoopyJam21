using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    public class Ghost : ScriptableObject
    {
        public string Name;
        public List<Package> Packages;
    }
}