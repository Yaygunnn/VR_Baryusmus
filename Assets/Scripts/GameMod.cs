using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMod 
{
    private static GameMod instance;

    public static GameMod Instance { get 
        { 
            if(instance == null) 
            {  instance = new GameMod();} 
            return instance; 
        } 
    }

    public Action PuzzleModStart;

    public Action PuzzleModEnd;

    public E_GameMod e_GameMod { get; private set; } = E_GameMod.Electronic;

    public void OpenPuzzle()
    {
        e_GameMod = E_GameMod.Puzzle;
        PuzzleModStart();
    }

    public void EndPuzzle()
    {
        e_GameMod = E_GameMod.Electronic;
        PuzzleModEnd();
    }
}
