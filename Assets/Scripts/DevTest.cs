using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTest : MonoBehaviour
{
    [SerializeField] GameFactory gameFactory;
    [SerializeField] BaseElectronicController StartDevice;
    void Start()
    {
        StartWithSelectedElectronic();
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
