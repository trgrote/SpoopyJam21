using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;

namespace Repository
{
    [CreateAssetMenu(fileName = "NewPackageRepository", menuName = "Repositories/New Package Repository")]
    public class PackageRepository : ScriptableObject
    {
        public List<Package> Packages;
    }
}