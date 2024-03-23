using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMain : MonoBehaviour
{
    public Adventurer adventurer;
    void Start()
    {
        adventurer.Attack();
    }
}
