using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class HackStartAnim : MonoBehaviour 
{
    public static HackStartAnim Instance;

    [SerializeField] private AnimationCurve CameraSpeedChange;

    private void Awake()
    {
        Instance = this;
    }
    public HackStartAnim()
    {
        EventHub.Ev_EndHackStartVideo += AnimEnd;
    }
    public void HackAnimStart(BaseElectronicController electronic)
    {
        StartCoroutine(CameraMoveToTarget(electronic));


    }

    private void AnimEnd()
    {
        HackReady.Instance.Hack();
        Debug.Log("videoEnded animde endsin");
    }

    private IEnumerator CameraMoveToTarget(BaseElectronicController electronic)
    {
        bool ReachedDestination = false;

        GameObject Player = GameModel.Instance.Player;

        float time = 0;

        float endtime = 0.3f;


        while (time < endtime ) 
        {
            time += Time.deltaTime;
            Player.transform.position = Vector3.Lerp(Player.transform.position, electronic.transform.position, CameraSpeedChange.Evaluate(time * 3));
            yield return null;
        }
        PlayVideo();
    }

    private void PlayVideo()
    {
        EventHub.FireStartHackStartVideo();
    }

    private void MovePlayerTowardsTarget()
    {

    }


}
