using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingTextAnim : MonoBehaviour
{
    public GameObject[] dots = new GameObject[3];
    [SerializeField] private float timeBetween;
    void Start()
    {
        StartCoroutine(LoadingAnimation());
    }

    IEnumerator LoadingAnimation()
    {
        while (true)
        {
            dots[0].SetActive(true);
            yield return new WaitForSeconds(timeBetween);
            dots[1].SetActive(true);
            yield return new WaitForSeconds(timeBetween);
            dots[2].SetActive(true);
            yield return new WaitForSeconds(timeBetween);
            foreach (var item in dots)
            {
                item.SetActive(false);
            }
        }

    }
}
