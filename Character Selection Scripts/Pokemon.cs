using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
[CreateAssetMenu(fileName = "Pokemon", menuName ="ScriptableObjects/Pokemon")]
public class Pokemon : ScriptableObject
{
    // Common attributes for all Pok�mon
    public string pokemonName;
    public Sprite pfpSprite;
    public string description;
    public int level;
    public int hp;
    public int strength;
    public int defense;
    public int speed;
    public int agility;
    public int luck;
    public Gender gender;
    public PokemonType type;
    public Moves[] moves;

    // Common behavior for all Pok�mon
    public void Attack()
    {
        Debug.Log($"{name} used Tackle!");
    }

    
}



