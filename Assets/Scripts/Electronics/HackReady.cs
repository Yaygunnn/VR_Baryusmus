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

    private BaseElectronicController HackableElectronic;

    public VR_InputReciever vR_InputReciever;

    public void PuzzleSuccess()
    {
        ElectronicManagerController.Instance.TakeControlOfANewElectronicDevice(HackableElectronic);
        GameMod.Instance.EndPuzzle();
    }
    public void CanHack(BaseElectronicController ElectronicDevice)
    {
        HackIsReady = true;
        HackableElectronic = ElectronicDevice;
    }

    public void CannotHack()
    {
        HackIsReady = false;
        HackableElectronic = null;
    }

    public void TryStartHack()
    {
        if (GameMod.Instance.e_GameMod == E_GameMod.Electronic)
        {
            if(HackIsReady)
            {
                HackStartAnim.Instance.HackAnimStart(HackableElectronic);

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
