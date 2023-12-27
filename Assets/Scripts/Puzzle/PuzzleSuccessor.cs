using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSuccessor : MonoBehaviour, IPuzzleSuccess
{
    public static IPuzzleSuccess CallSucces;

    public void PuzzleSuccess()
    {
        if (CallSucces != null)
        {
            CallSucces.PuzzleSuccess();
            Debug.Log("PuzzleSuccess");
        }
    }
   
    
}
