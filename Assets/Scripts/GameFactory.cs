using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFactory : MonoBehaviour
{
    [SerializeField] private InputScript inputScript;
    [SerializeField] private PuzzleController puzzleController;
    [SerializeField] private VR_InputReciever vR_InputReciever;
    [SerializeField] private VRPuzzleHandModel vRP_HandModel;
    [SerializeField] private PuzzleRoomModel puzzleRoomModel;
    [SerializeField] private GameObject Player;
    [SerializeField] private ElectCalculateController electCalculateController;
    
    void Awake()
    {
        //inputScript.SpaceAction = ElectronicManagerController.Instance.ChangeToARandomElectronic;
        //ElectronicManagerController.Instance.SetModelVariables(inputScript);
        //inputScript.puzzleController = puzzleController;
        vRP_HandModel.VRInput = vR_InputReciever;
        puzzleRoomModel.Player = Player;
        ElectronicManagerController.Instance.SetElectCalculateController(electCalculateController);
        GameModel.Instance.SetValues(Player);
        HackReady.Instance.vR_InputReciever = vR_InputReciever;

        GameMod.Instance.PuzzleModEnd += HackReady.Instance.UnifyInput;



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
