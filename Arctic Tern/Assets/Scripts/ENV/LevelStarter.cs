using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadein;
    public AudioSource readyFX;
    public AudioSource goFX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.4f);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        goFX.Play();
        BirdMove.canMove = true;
    }

}
