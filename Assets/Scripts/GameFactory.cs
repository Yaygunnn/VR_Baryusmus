using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFactory : MonoBehaviour
{
    [SerializeField] private InputScript inputScript;
    [SerializeField] private PuzzleController puzzleController;
    void Start()
    {
        inputScript.SpaceAction = ElectronicManagerController.Instance.ChangeToARandomElectronic;
        ElectronicManagerController.Instance.SetModelVariables(inputScript);
        inputScript.puzzleController = puzzleController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
