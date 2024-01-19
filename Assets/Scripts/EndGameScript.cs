using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
   
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<BaseElectronicController>() != null)
        {
            Debug.Log("EndGame");
            SceneManager.LoadScene(2);
        }
    }
}
