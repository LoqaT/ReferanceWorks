using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceScrip : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.forward *5, ForceMode.Force);

        if (Input.GetKey(KeyCode.A)) 
        {
            GetComponent<Rigidbody>().AddForce(-10, 0, 0, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            GetComponent<Rigidbody>().AddForce(10, 0, 0, ForceMode.Force);
        }



    }
}
