using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventHub 
{
    public static event Action Ev_StartHackStartVideo;

    public static event Action Ev_EndHackStartVideo;

    public static event Action Ev_StartPuzzleSuccessVideo;

    public static event Action Ev_EndPuzzleSuccessVideo;


    public static void FireStartHackStartVideo() { Ev_StartHackStartVideo?.Invoke(); }

    public static void FireEndHackStartVideo() { Ev_EndHackStartVideo?.Invoke(); }

    public static void FireStartPuzzleSuccessVideo() { Ev_StartPuzzleSuccessVideo?.Invoke(); }

    public static void FireEndPuzzleSuccessVideo() { Ev_EndPuzzleSuccessVideo?.Invoke(); }


}
