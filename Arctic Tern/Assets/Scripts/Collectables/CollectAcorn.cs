using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectAcorn : MonoBehaviour
{
    public AudioSource acornFX;
    void OnTriggerEnter(Collider other)
    {
        acornFX.Play();
        this.gameObject.SetActive(false);
    }
}
