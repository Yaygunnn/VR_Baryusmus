using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFactory : MonoBehaviour
{
    //[SerializeField] private InputScript inputScript;
    //[SerializeField] private PuzzleController puzzleController;
    [SerializeField] private VR_InputReciever vR_InputReciever;
    [SerializeField] private VRPuzzleHand vRP_RightHandModel;
    [SerializeField] private VRPuzzleHand vRP_LeftHandModel;
    [SerializeField] private PuzzleRoomModel puzzleRoomModel;
    [SerializeField] private GameObject Player;
    [SerializeField] private ElectCalculateController electCalculateController;
    [SerializeField] private Camera PlayerCamera;
    [SerializeField] private VideoChanger videoChanger;
    
    
    void Awake()
    {
        //inputScript.SpaceAction = ElectronicManagerController.Instance.ChangeToARandomElectronic;
        //ElectronicManagerController.Instance.SetModelVariables(inputScript);
        //inputScript.puzzleController = puzzleController;
 
        puzzleRoomModel.Player = Player;
        ElectronicManagerController.Instance.SetElectCalculateController(electCalculateController);
        GameModel.Instance.SetValues(Player, PlayerCamera);
        HackReady.Instance.vR_InputReciever = vR_InputReciever;

        CameraLocationSeter.Player = Player;
        CameraLocationSeter.Camera = PlayerCamera;


        InputChangeManage();


    }

    private void InputChangeManage()
    {
        InputChanger inputChanger = new InputChanger(vRP_RightHandModel, vRP_LeftHandModel, vR_InputReciever);

        GameMod.Instance.PuzzleModEnd += inputChanger.ElectronicModStart;
        GameMod.Instance.PuzzleModStart += inputChanger.PuzzleModStart;
    }
    private void Start()
    {
        GameMod.Instance.PuzzleModEnd();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
