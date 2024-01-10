using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject creditCanvas;
    [SerializeField] private GameObject optionsCanvas;
    [SerializeField] private GameObject mainMenuCanvas;
    public void ClickPlay()
    {
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void ClickCredits()
    {
        mainMenuCanvas.SetActive(false);
        creditCanvas.SetActive(true);   
    }

    public void ClickOptions()
    {
        optionsCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void ClickBackToMainMenu()
    {
        optionsCanvas.SetActive(false);
        creditCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}
            