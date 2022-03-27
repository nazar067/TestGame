using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SpawnStone : MonoBehaviour
{
    public Rigidbody rigidbody;
    public GameObject[] objects;
    public GameObject stone;
    private GameObject cur_object;
    public GameObject script_stone;
    private Following script;
    private float y = (float)0.58;
    void Update()
    {
        InvokeRepeating("Spawn", 5, 0);
    }
    void Spawn()
    {
        if (stone == null)
        {
            TextMesh text = GameObject.Find("Message").GetComponent<TextMesh>();
            text.text = "Working";
            script = script_stone.GetComponent<Following>();
            script.enabled = false;
            cur_object = Instantiate(objects[0], new Vector3(Random.Range(-3, (float)-3.7), y, Random.Range((float)0.9, (float)2.3)),
            Quaternion.identity);
            cur_object.name = "NewStone";
            cur_object.SetActive(true);
            stone = cur_object;
        }
        else
        {
            TextMesh text = GameObject.Find("Message").GetComponent<TextMesh>();
            text.text = "full";
        }
    }
}
