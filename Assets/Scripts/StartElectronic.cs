using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartElectronic : MonoBehaviour
{
    
    [SerializeField] BaseElectronicController StartDevice;

    private void Awake()
    {
        StartWithSelectedElectronic();
        
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartWithSelectedElectronic()
    {
        if (StartDevice != null)
        {
            ElectronicManagerController.Instance.TakeControlOfANewElectronicDevice(StartDevice);
        }
        else Debug.Log("Start With Which Electronic?");
    }
}
