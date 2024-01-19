using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectCalculateController : MonoBehaviour
{
    [SerializeField] private ElectCalculateModel model;
    void Start()
    {
        SetModelPlayer();   
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMod.Instance.e_GameMod==E_GameMod.Electronic)
        {
            CalculateAllAngles();
        }
    }

    /*private void CalculateAllAngles()
    {
        SetHeadPosAndForwardVector();
        float degre;
        float mindegre=float.MaxValue;
        BaseElectronicController minElectronicDevice=null;
        foreach(BaseElectronicController electronicDevice in model.AllElectronics)
        {
            degre = CalculateDegreBetweenVectors(CalculateHeadToElectronicVector(electronicDevice));
            IDegreElectronic iDegreElectronic = electronicDevice.GetComponent<IDegreElectronic>();
            if(iDegreElectronic != null)
            {
                iDegreElectronic.DegreIs(degre);
            }

            if(mindegre > degre)
            {
                mindegre = degre;
                minElectronicDevice = electronicDevice;
            }
        }

        if (mindegre < model.MiniNecessaryDegre) 
        {
            Debug.Log("Min degre is " +mindegre+ "Necessery min is "+model.MiniNecessaryDegre);
            IDegreElectronic iDegreElectronic = minElectronicDevice.GetComponent<IDegreElectronic>();
            if (iDegreElectronic != null)
            {
                iDegreElectronic.InHackDegre();
                HackReady.Instance.CanHack(minElectronicDevice);
            }
            else { Debug.Log("There is no iDegreElectronic interface"); }
        }
        else { HackReady.Instance.CannotHack(); }

        HideCurrentElectronicRenderer();
    }*/

    private void CalculateAllAngles()
    {
        SetHeadPosAndForwardVector();
        float degre;
        float mindegre = float.MaxValue;
        BaseElectronicController minElectronicDevice = null;
        foreach (BaseElectronicController electronicDevice in model.AllElectronics)
        {
            if (electronicDevice == model.CurrentElectronicController)
            {
                HideCurrentElectronicRenderer();
            }
            else
            {
                degre = CalculateDegreBetweenVectors(CalculateHeadToElectronicVector(electronicDevice));
                IDegreElectronic iDegreElectronic = electronicDevice.GetComponentInChildren<IDegreElectronic>();
                if (iDegreElectronic != null)
                {
                    iDegreElectronic.DegreIs(degre);
                }

                if (mindegre > degre)
                {
                    mindegre = degre;
                    minElectronicDevice = electronicDevice;
                }
            }
            
        }

        if (mindegre < model.MinNecessaryDegre)
        {
            //Debug.Log("Min degre is " + mindegre + "Necessery min is " + model.MinNecessaryDegre);
            IDegreElectronic iDegreElectronic = minElectronicDevice.GetComponentInChildren<IDegreElectronic>();
            if (iDegreElectronic != null)
            {
                iDegreElectronic.InHackDegre();
            }
            else 
            { 
                Debug.Log("There is no iDegreElectronic interface"); 
            }
            HackReady.Instance.CanHack(minElectronicDevice);
        }
        else { HackReady.Instance.CannotHack(); }

        
    }


    private void InformElectronicDeviceAboutDegre(float degre)
    {

    }
    private void SetHeadPosAndForwardVector()
    {
        model.HeadPos = model.HeadVr.position;
        model.HeadForward = model.HeadVr.forward;
    }

    private float CalculateDegreBetweenVectors(Vector3 HeadToElectronic)
    {
        return Vector3.Angle(model.HeadForward, HeadToElectronic);
    }
    private Vector3 CalculateHeadToElectronicVector(BaseElectronicController controller)
    {
        return controller.transform.position-model.HeadPos;
    }

    public void SetNewCurrentBaseElectronic(BaseElectronicController baseElectronic, List<BaseElectronicController> allElectronics)
    {
        model.CurrentElectronicController = baseElectronic;
        model.AllElectronics = allElectronics;                        
    }

    private void HideCurrentElectronicRenderer()
    {
        IDegreElectronic iDegreElectronic = model.CurrentElectronicController.GetComponentInChildren<IDegreElectronic>();
        if (iDegreElectronic != null)
        {
            iDegreElectronic.Hide();
        }
    }
    private void SetModelPlayer()
    {
        model.Player=GameModel.Instance.Player;
    }
}
