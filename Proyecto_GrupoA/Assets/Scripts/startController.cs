using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startController : MonoBehaviour
{
    public GameObject count3;
    public GameObject count2;
    public GameObject count1;
    public GameObject countGo;
    public GameObject start;

    void Start()
    {
        StartCoroutine(countSequence());
    }

    IEnumerator countSequence()
    {
        yield return new WaitForSeconds(1.5f);
        count3.SetActive(true);
        yield return new WaitForSeconds(1);
        count2.SetActive(true);
        yield return new WaitForSeconds(1);
        count1.SetActive(true);
        yield return new WaitForSeconds(1);
        countGo.SetActive(true);
    }
}
