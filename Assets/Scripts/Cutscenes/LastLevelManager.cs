using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastLevelManager : MonoBehaviour
{
    public GameObject[] objs = new GameObject[3];
    void Start()
    {
        StartCoroutine(LastLevelManage());
    }

    IEnumerator LastLevelManage()
    {
        yield return new WaitForSeconds(2f);
        objs[0].SetActive(true);
        yield return new WaitForSeconds(5f);
        objs[0].SetActive(false);
        objs[1].SetActive(true);
        yield return new WaitForSeconds(5f);
        objs[1].SetActive(false);
        objs[2].SetActive(true);

    }
}
