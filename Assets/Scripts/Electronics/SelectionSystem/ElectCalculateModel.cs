using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectCalculateModel : MonoBehaviour
{
    [HideInInspector] public List<BaseElectronicController> AllElectronics = new List<BaseElectronicController>();
    [HideInInspector]  public BaseElectronicController CurrentElectronicController;
    [HideInInspector] public GameObject Player;
    public Transform HeadVr;

    [HideInInspector] public Vector3 HeadPos;
    [HideInInspector] public Vector3 HeadForward;



    
    [HideInInspector] public float MinNecessaryDegre = 5;
}
