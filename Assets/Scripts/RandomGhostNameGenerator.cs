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

    public string GenerateRandomName()
    {
        var prefix = Random.value <= _prefixChance ? 
            _ghostNames.Names.Where(n => n.Prefix).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";
       
        var first = Random.value <= _firstNameChance ? 
            _ghostNames.Names.Where(n => n.FirstName).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";
            
        var last = Random.value <= _lastNameChance ? 
            _ghostNames.Names.Where(n => n.LastName).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";

        var suffix = Random.value <= _sufffixChance ? 
            _ghostNames.Names.Where(n => n.Suffix).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";

        return string.Join(" ", new string[]{prefix, first, last, suffix}.Where(n => n.Length > 0));
    }

    [NaughtyAttributes.Button]
    public void TestRandomName()
    {
        Debug.Log(GenerateRandomName());
    }
}
