using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRun : MonoBehaviour
{
    public GameObject liveAcorns;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject endFadeOut;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequnce());
    }

    IEnumerator EndSequnce()
    {
        yield return new WaitForSeconds(3);
        liveAcorns.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(3);
        endFadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
