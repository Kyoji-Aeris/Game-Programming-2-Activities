using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject startPanel;

    public void OnClick()
    {
        startPanel.gameObject.SetActive(false);
    }
}
