using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAcorn : MonoBehaviour
{
    public AudioSource acornFX;
    void OnTriggerEnter(Collider other)
    {
        acornFX.Play();
        CollectableControl.acornCount += 1;
        this.gameObject.SetActive(false);
    }
}
