using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaderChanger : MonoBehaviour
{
    public static CameraShaderChanger Instance;

    public Camera cam;
    public Color baseColor;
    public Color blackColor;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        cam = GetComponent<Camera>();
        baseColor = cam.backgroundColor;
    }

    
    public void InPuzzleRoomMode()
    {
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = blackColor;
    }

    public void OutPuzzleRoomMode()
    {
        cam.clearFlags = CameraClearFlags.Skybox;
        cam.backgroundColor = baseColor;
    }
}
