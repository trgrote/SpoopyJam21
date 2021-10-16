using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Models;
using UnityEngine;

public static class RandomGhostGenerators
{
    public static string GenerateRandomName(List<Models.GhostName> names, float prefixChance, float firstNameChance, float lastNameChance, float sufffixChance)
    {
        var prefix = Random.value <= prefixChance ? 
            names.Where(n => n.Prefix).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";
       
        var first = Random.value <= firstNameChance ? 
            names.Where(n => n.FirstName).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";
            
        var last = Random.value <= lastNameChance ? 
            names.Where(n => n.LastName).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";

        var suffix = Random.value <= sufffixChance ? 
            names.Where(n => n.Suffix).OrderBy(n => Random.value).Select(n => n.Name).FirstOrDefault() :
            "";

        return string.Join(" ", new string[]{prefix, first, last, suffix}.Where(n => n.Length > 0));
    }

    public static Ghost NewGhost(List<Models.Package> packages, List<Models.GhostName> names, float prefixChance, float firstNameChance, float lastNameChance, float sufffixChance)
    {
        var name = GenerateRandomName(names, prefixChance, firstNameChance, lastNameChance, sufffixChance);
        var package = packages.OrderBy(p => Random.value).FirstOrDefault();

        var ghost = ScriptableObject.CreateInstance<Ghost>();
        ghost.Name = name + " the " + package.Name;
        ghost.AttributeScores = package.Attributes.Aggregate(
            new Dictionary<Attribute, int>(), (result, attribute) => {
                result[attribute] = result.ContainsKey(attribute) ? result[attribute] + 1 : 1;
                return result;
            }
        );

        return ghost;
    }
}
