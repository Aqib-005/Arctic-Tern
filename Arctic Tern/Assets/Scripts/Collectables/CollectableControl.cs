using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int acornCount;
    public GameObject acornCountDisplay;
    public GameObject acornEndDisplay;

    void Update()
    {
        acornCountDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + acornCount ;
        acornEndDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + acornCount ;
    }
}
