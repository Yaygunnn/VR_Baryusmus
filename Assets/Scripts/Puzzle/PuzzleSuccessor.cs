using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSuccessor : MonoBehaviour
{
    public static PuzzleSuccessor Instance;

    public static IPuzzleSuccess CallSucces;

    private void Start()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        EventHub.Ev_EndPuzzleSuccessVideo += FireSuccess;
    }
    private void OnDisable()
    {
        EventHub.Ev_EndPuzzleSuccessVideo -= FireSuccess;
    }
    public void PuzzleSolved()
    {
        EventHub.FireStartPuzzleSuccessVideo();
    }

    private void FireSuccess()
    {
        if(PuzzleSuccessor.CallSucces != null)
        {
            PuzzleSuccessor.CallSucces.PuzzleSuccess();
        }
    }

}
