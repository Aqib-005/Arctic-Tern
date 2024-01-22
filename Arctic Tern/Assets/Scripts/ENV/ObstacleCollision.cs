using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject theBird;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject mainCam;
    public GameObject levelControl;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<MeshCollider>().enabled = false;    
        theBird.GetComponent<BirdMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Falling Back Death");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRun>().enabled = true;
    }
}
