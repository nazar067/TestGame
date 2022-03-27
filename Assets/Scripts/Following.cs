using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following : MonoBehaviour
{
    //Движение предметов вместе с игроком
    public Transform player;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vector3 = new Vector3(player.position.x, player.position.y + 1, player.position.z);
        transform.position = Vector3.MoveTowards(transform.position, vector3, 1f);
    }
}
