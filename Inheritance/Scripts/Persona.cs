using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persona : MonoBehaviour
{
    
    public string name;
    public enum Arcana
    {
        Fool, Chariot, Justice
    }

    public Arcana arcana;
    public int level;
    public int strength;
    public int magic;
    public int endurance;
    public int agility;
    public int luck;
    public string skillCard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
