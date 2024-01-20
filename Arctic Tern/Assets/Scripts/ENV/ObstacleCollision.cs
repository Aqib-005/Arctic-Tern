using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject theBird;
    public GameObject charModel;
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<MeshCollider>().enabled = false;    
        theBird.GetComponent<BirdMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Falling Back Death");
    }
}
