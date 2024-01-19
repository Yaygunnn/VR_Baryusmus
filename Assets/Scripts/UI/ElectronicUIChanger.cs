using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronicUIChanger : MonoBehaviour
{


    public static ElectronicUIChanger Instance;     
   
    public GameObject CameraUI;

    public GameObject CleanerRobotUI;


    private void Awake()
    {
        Instance = this;

        GameMod.Instance.PuzzleModStart += CloseAllUI;
    }

    public void CloseAllUI()
    {
        CameraUI.SetActive(false);
        CleanerRobotUI.SetActive(false);
    }
    public void OpenCameraUI(BaseCameraModel baseCameraModel)
    {
        Debug.Log("Open Camera UI");
        CloseAllUI();
        CameraUI.SetActive(true);
    }

    public void OpenCleanerRobotUI()
    {
        Debug.Log("Open Robot UI");
        CloseAllUI();
        CleanerRobotUI.SetActive(true);
    }
}
