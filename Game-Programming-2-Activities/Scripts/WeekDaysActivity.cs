using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekDaysActivity : MonoBehaviour
{
    public EnumDays weekday;
    void Start()
    {
        switch (weekday)
        {
            case EnumDays.Monday: Debug.Log("Monday is selected."); break;
            case EnumDays.Tuesday: Debug.Log("Tuesday is selected."); break;
            case EnumDays.Wednesday: Debug.Log("Wednesday is selected."); break;
            case EnumDays.Thursday: Debug.Log("Thursday is selected."); break;
            case EnumDays.Friday: Debug.Log("Friday is selected."); break;
            case EnumDays.Saturday: Debug.Log("Saturday is selected."); break;
            case EnumDays.Sunday: Debug.Log("Sunday is selected."); break;
            default:
                Debug.Log("No day is selected.");
                break;
        }
    }
}
