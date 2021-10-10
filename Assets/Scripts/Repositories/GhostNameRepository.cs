using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;

namespace Repository
{
    [CreateAssetMenu(fileName = "NewGhostNameRepository", menuName = "Repositories/New GhostName Repository")]
    public class GhostNameRepository : ScriptableObject
    {
        public List<GhostName> Names;
    }
}