using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ares : Persona
{
    // Start is called before the first frame update
    void Start()
    {
        name = "Ares";
        arcana = Arcana.Chariot;
        level = 19;

        strength = 17;
        magic = 10;
        endurance = 15;
        agility = 9;
        luck = 13;
    }
}
