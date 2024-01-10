using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel 
{

    private static GameModel instance;

    public static GameModel Instance
    {
        get
        {
            if (instance == null)
            { instance = new GameModel(); }
            return instance;
        }
    }


    public GameObject Player { get; private set; }

    public Camera camera { get; private set; }


    public void SetValues(GameObject player, Camera cam)
    {
        Player = player;

        camera = cam;
    }
}
