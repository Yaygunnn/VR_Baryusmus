using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronicManagerController 
{
    private ElectronicManagerModel model;

    private static ElectronicManagerController instance;
    public static ElectronicManagerController Instance
    {
        get { 
                if (instance == null)
                {
                    instance = new ElectronicManagerController();
                    instance.model = new ElectronicManagerModel();
                }
                return instance;    
            }
    }

    public void TakeControlOfANewElectronicDevice(BaseElectronicController baseElectronic)
    {
        LoseControlOfPreviousElectronicDevice();
        TakeControlOf(baseElectronic);
    }

    public void AddToTheAllElectronicList(BaseElectronicController baseElectronic)
    {
        model.AllElectronics.Add(baseElectronic);

        
    }
    
    public void ChangeToARandomElectronic()
    {
        BaseElectronicController AnElectronicDevice;
        do 
        {
            AnElectronicDevice = GetRandomElectronic();
        } while (AnElectronicDevice == model.CurrentElectronicController);

        TakeControlOfANewElectronicDevice(AnElectronicDevice);

    }

    public void SetModelVariables(InputScript inputscript)
    {
        model.inputScript=inputscript;
    }

    private BaseElectronicController GetRandomElectronic()
    {
        Debug.Log(model.AllElectronics.Count);
        return model.AllElectronics[Random.Range(0, model.AllElectronics.Count)];

    }

    private void TakeControlOf(BaseElectronicController baseElectronic)
    {
        model.CurrentElectronicController = baseElectronic;
        model.CurrentElectronicController.TakenControl();

        model.electCalculateController.SetNewCurrentBaseElectronic(baseElectronic, model.AllElectronics);

        //ChangeInputElectronic();
    }

    private void ChangeInputElectronic()
    {
        model.inputScript.ElectronicController=model.CurrentElectronicController;
    }
    private void LoseControlOfPreviousElectronicDevice()
    {
        if (model.CurrentElectronicController != null)
        {
            model.CurrentElectronicController.LostControl();
        }
    }

    public void SetElectCalculateController(ElectCalculateController controller)
    {
        model.electCalculateController=controller;
    }
}
