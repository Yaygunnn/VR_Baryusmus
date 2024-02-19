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

    private HackReadyModel model=new HackReadyModel();

    public void PuzzleSuccess()
    {
        ElectronicManagerController.Instance.TakeControlOfANewElectronicDevice(model.SelectedElectronic);
        GameMod.Instance.EndPuzzle();
        model.IsHacking = false;
    }
    public void CanHack(BaseElectronicController ElectronicDevice)
    {
        if (model.IsHacking)
        {
            return;
        }
        model.HackIsReady = true;
        model.HackableElectronic = ElectronicDevice;
    }

    public void CannotHack()
    {
        if(model.IsHacking)
        {
            return;
        }
        model.HackIsReady = false;
        model.HackableElectronic = null;
    }

    public void TryStartHack()
    {
        if (GameMod.Instance.e_GameMod == E_GameMod.Electronic)
        {
            if(model.HackIsReady)
            {
                if(!model.IsHacking)
                {
                    model.IsHacking = true;
                    HackStartAnim.Instance.HackAnimStart(model.HackableElectronic);
                    model.SelectedElectronic = model.HackableElectronic;
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
