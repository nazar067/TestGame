using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //������ main camera �� �������
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
    }
}
