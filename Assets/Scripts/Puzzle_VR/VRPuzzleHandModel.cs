using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRPuzzleHandModel : MonoBehaviour
{
    
    [SerializeField] public Transform Head;
    [SerializeField] public Transform Hand;
    [SerializeField] public bool IsRighthand;
    public BasePuzzleDragable basePuzzleDragable;
    [SerializeField] public float Distance { get; } = 20;

    public float DragSpeedX = 2;
    public float DragSpeedY = 1;

    [SerializeField] public GameObject LocationShowHand;

    public Vector3 PreviousHandPos;

    public bool Draging;


    public float MinNecesseryCloseDistance = 0.3f;

    public float minPuzzleDistance;

    

    

    


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
