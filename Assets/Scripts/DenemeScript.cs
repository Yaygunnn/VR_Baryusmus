using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenemeScript : MonoBehaviour, IPuzzleSuccess
{
    // Start is called before the first frame update
    void Start()
    {
        PuzzleSuccessor.CallSucces = (IPuzzleSuccess)this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PuzzleSuccess()
    {
        Debug.Log("Yeeeehu");
    }
}
