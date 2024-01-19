using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstCutSceneManager : MonoBehaviour
{
    public GameObject[] texts = new GameObject[6];
    public GameObject[] dots = new GameObject[3];
    void Start()
    {
        StartCoroutine(BeginningScene());
    }

    IEnumerator BeginningScene()
    {
        yield return new WaitForSeconds(1f);
        texts[0].SetActive(true);
        yield return new WaitForSeconds(4f);
        texts[0].SetActive(false);
        texts[1].SetActive(true);
        yield return new WaitForSeconds(5f);
        texts[1].SetActive(false);
        texts[2].SetActive(true);
        foreach (var item in dots)
        {
            item.SetActive(false);
        }
        yield return new WaitForSeconds(5f);
        texts[2].SetActive(false);
        texts[3].SetActive(true);
        yield return new WaitForSeconds(5f);
        texts[3].SetActive(false);
        texts[4].SetActive(true);
        yield return new WaitForSeconds(5f);
        texts[4].SetActive(false);
        texts[5].SetActive(true);
        yield return new WaitForSeconds(6f);
        var buildIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(buildIndex + 1);
    }
}
