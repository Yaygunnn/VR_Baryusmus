using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRoomController : MonoBehaviour
{
    [SerializeField] PuzzleRoomModel model;
    void Start()
    {
        UniteWithGameMod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void PuzzleModOpen()
    {
        //ShaderOpen.Instance.OpenShaderMode();
        //TeleportPlayer();
        CameraLocationSeter.SetNewCameraTransformObject(model.PlayerTeleportLocation.gameObject);
    }

    private void UniteWithGameMod()
    {
        GameMod.Instance.PuzzleModStart += PuzzleModOpen;
    }

    private void TeleportPlayer()
    {
        model.Player.transform.position = model.PlayerTeleportLocation.position;
        model.Player.transform.rotation=model.PlayerTeleportLocation.rotation;
    }
}
