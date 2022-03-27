using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnIron : MonoBehaviour
{
    public GameObject[] inventory_stone = new GameObject[5];
    private GameObject cur_object;
    public GameObject iron;
    private float y = (float)0.58;
    public Rigidbody user;
    private PlayerInventory player;
    public Text text;
    void Update()
    {
        InvokeRepeating("Spawn", 5, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "InventoryStone")
        {
            cur_object = Instantiate(collision.gameObject, new Vector3(5, 5, 5), Quaternion.identity);
            for (int i = 0; i < 1; i++)
            {
                if (inventory_stone[i] == null)
                {
                    inventory_stone[i] = cur_object;
                }
                else if (inventory_stone[i + 1] == null)
                {
                    inventory_stone[i + 1] = cur_object;
                }
                else if (inventory_stone[i + 2] == null)
                {
                    inventory_stone[i + 2] = cur_object;
                }
                else if (inventory_stone[i + 3] == null)
                {
                    inventory_stone[i + 3] = cur_object;
                }
                else if (inventory_stone[i + 4] == null)
                {
                    inventory_stone[i + 4] = cur_object;
                }
            }
            Destroy(collision.gameObject);
            player = user.gameObject.GetComponent<PlayerInventory>();
            player.num--;
            text.text = "Inventory: " + player.num;
            InvokeRepeating("Spawn", 5, 0);
        }
    }
    void Spawn()
    {
        for (int i = 0; i < inventory_stone.Length; i++)
        {
            if (inventory_stone[i] != null)
            {
                TextMesh text = GameObject.Find("MsgFactory2").GetComponent<TextMesh>();
                text.text = "Working";
                Instantiate(iron, new Vector3(Random.Range(4, (float)4.8), y, Random.Range(5, (float)3.2)), Quaternion.identity);
                inventory_stone[i] = null;
                Destroy(cur_object);
            }
            else
            {
                TextMesh text = GameObject.Find("MsgFactory2").GetComponent<TextMesh>();
                text.text = "I need stone";
            }
        }
    }
}
