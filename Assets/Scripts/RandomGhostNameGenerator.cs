using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomGhostNameGenerator : MonoBehaviour
{
    public float _prefixChance = 0.2f;
    public float _firstNameChance = 1f;
    public float _lastNameChance = 0.8f;
    public float _sufffixChance = 0.2f;

    public Repository.GhostNameRepository _ghostNames;

    public string GenerateRandomName()
    {
        var prefix = Random.value <= _prefixChance ? 
            _ghostNames.Names.Where(n => n.Prefix).OrderBy(n => Random.value).Select(n => name).FirstOrDefault() :
            "";

        var first = Random.value <= _firstNameChance ? 
            _ghostNames.Names.Where(n => n.FirstName).OrderBy(n => Random.value).Select(n => name).FirstOrDefault() :
            "";
            
        var last = Random.value <= _lastNameChance ? 
            _ghostNames.Names.Where(n => n.LastName).OrderBy(n => Random.value).Select(n => name).FirstOrDefault() :
            "";

        var suffix = Random.value <= _sufffixChance ? 
            _ghostNames.Names.Where(n => n.Suffix).OrderBy(n => Random.value).Select(n => name).FirstOrDefault() :
            "";

        return string.Join(" ", new string[]{prefix, first, last, suffix}.Where(n => n.Length > 0));
    }
}
