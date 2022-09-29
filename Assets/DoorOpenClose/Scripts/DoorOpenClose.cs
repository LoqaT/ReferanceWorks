using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DoorOpenClose : MonoBehaviour 
{
    public int RotateDegree;
    public int CloseDoor;
    public float AnimationTime;
    public GameObject Door;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Door.transform.DORotate(new Vector3(0,RotateDegree,0),AnimationTime);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Door.transform.DORotate(new Vector3(0,CloseDoor, 0),AnimationTime);
        }
    }









}




