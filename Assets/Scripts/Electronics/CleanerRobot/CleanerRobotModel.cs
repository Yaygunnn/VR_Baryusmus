using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerRobotModel : MonoBehaviour
{
    [SerializeField] public CharacterController characterController;

    public float MaxSpeed;

    public float SmoothTime;

    [HideInInspector] public Vector2 CurrentMove;

    [HideInInspector] public Vector2 NewMoveInput;

    [SerializeField] public Transform CameraLocation;

    [SerializeField] public float RotationLerpValue;

    [HideInInspector] public bool BeingController;

    [HideInInspector] public Vector3 StartPos;

    

    [HideInInspector] public float TravelDistance = 1;

    [HideInInspector] public bool GoForward;

    

     public float TravlSpeed = 0.4f;
}
