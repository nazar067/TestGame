using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //Слежка main camera за игроком
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
    }
}
