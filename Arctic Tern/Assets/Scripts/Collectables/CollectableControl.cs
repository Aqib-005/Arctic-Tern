using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int acornCount;
    public GameObject acornCountDisplay;

    void Update()
    {
        acornCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + acornCount ;
    }
}
