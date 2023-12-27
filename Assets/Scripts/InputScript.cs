using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public Action SpaceAction;
    //public Action<Vector2> MouseMovement;
    public BaseElectronicController ElectronicController;

    public PuzzleController puzzleController;

    public 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpaceCheck();
        MouseScrollCheck();
        PuzzleMod();
        
    }



    void PuzzleMod()
    {
        Mousebutton0f();
        MouseDrag();
    }

    void Mousebutton0f()
    {
        if(Input.GetMouseButtonDown(0))
        {
            puzzleController.TryToHoldAPuzzlePiece();
        }

        if(Input.GetMouseButtonUp(0))
        {
            puzzleController.TryToStopDrag();
        }
    }

    private void MouseDrag()
    {
        puzzleController.TryDrag(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
        
    }
    void SpaceCheck()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpaceAction != null)
            {
                SpaceAction();
            }
        }
    }

    void ElectronicControllerButtons()
    {
        if(ElectronicController != null)
        {
            MouseScrollCheck();

        }
    }
    void MouseScrollCheck()
    {
        /*if(MouseMovement != null)
        {
            MouseMovement(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));

        }*/

        ElectronicController.MouseMovementX((Input.GetAxis("Mouse X")));

        ElectronicController.MouseMovementY((Input.GetAxis("Mouse Y")));
    }
}
