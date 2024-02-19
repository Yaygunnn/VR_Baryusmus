using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HackReady: IPuzzleSuccess
{
    private static HackReady instance;
    public static HackReady Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new HackReady();
                
            }
            return instance;
        }
    }

    private bool HackIsReady;

    private bool IsHacking;

    private BaseElectronicController HackableElectronic;

    private BaseElectronicController SelectedElectronic;

    public VR_InputReciever vR_InputReciever;

    public void PuzzleSuccess()
    {
        ElectronicManagerController.Instance.TakeControlOfANewElectronicDevice(SelectedElectronic);
        GameMod.Instance.EndPuzzle();
        IsHacking = false;
    }
    public void CanHack(BaseElectronicController ElectronicDevice)
    {
        if (IsHacking)
        {
            return;
        }
        HackIsReady = true;
        HackableElectronic = ElectronicDevice;
    }

    public void CannotHack()
    {
        if(IsHacking)
        {
            return;
        }
        HackIsReady = false;
        HackableElectronic = null;
    }

    public void TryStartHack()
    {
        if (GameMod.Instance.e_GameMod == E_GameMod.Electronic)
        {
            if(HackIsReady)
            {
                if(!IsHacking)
                {
                    IsHacking = true;
                    HackStartAnim.Instance.HackAnimStart(HackableElectronic);
                    Debug.Log(HackableElectronic);
                    SelectedElectronic = HackableElectronic;
                }
            }
        }
    }

    private void StartHackAnim()
    {
        Debug.Log("VideoGir");
    }

    public void Hack()
    {
        GameMod.Instance.OpenPuzzle();
        PuzzleSuccessor.CallSucces = this;
    }
    
}
