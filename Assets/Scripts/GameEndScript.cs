using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndScript : MonoBehaviour
{
    private BaseElectronicController electronic;
    private void OnTriggerEnter(Collider other)
    {
        electronic = other.GetComponent<BaseElectronicController>();
        if(electronic != null)
        {
            SceneManager.LoadScene(3);
        }

    }
}
