using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Windows;

public class InputChanger 
{
    

    public VRPuzzleHand RightHand;
    public VRPuzzleHand LeftHand;

    private HackReady hackReady = HackReady.Instance;

    public VR_InputReciever vR_InputReciever;

    private BaseElectronicController baseElectronicController;

    public InputChanger(VRPuzzleHand rightHand, VRPuzzleHand leftHand, VR_InputReciever inputreciever)
    {
        RightHand = rightHand;
        LeftHand = leftHand;
        vR_InputReciever = inputreciever;
    }


    public void PuzzleModStart()
    {
        Nulify();       
        vR_InputReciever.RightTrigger = RightHand.SearchPuzzlePiece;
        vR_InputReciever.RightTriggerCancell = RightHand.TryStopDrag;
        vR_InputReciever.LeftTrigger = LeftHand.SearchPuzzlePiece;
        vR_InputReciever.LeftTriggerCancell = LeftHand.TryStopDrag;
    }

    public void ElectronicModStart()
    {
        Nulify();
        GetElectronicDevice();
        vR_InputReciever.RightTrigger = hackReady.TryStartHack;
        vR_InputReciever.LeftTrigger = hackReady.TryStartHack;

        vR_InputReciever.LeftAnalog2d = baseElectronicController.LeftAnalog2D;

    }

    private void Nulify()
    {
        vR_InputReciever.RightTrigger = null;
        vR_InputReciever.RightTriggerCancell = null;
        vR_InputReciever.LeftTrigger = null;
        vR_InputReciever.LeftTriggerCancell = null;
        vR_InputReciever.LeftAnalog2d = null;
    }

    private void GetElectronicDevice()
    {
        baseElectronicController = ElectronicManagerController.Instance.GetCurrentElectronicDevice();
    }
}
