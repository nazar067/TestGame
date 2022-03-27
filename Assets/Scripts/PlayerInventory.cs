using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    //Инвентарь игрока
    public GameObject[] inventory = new GameObject[5];
    private GameObject cur_object;
    public Rigidbody rigidbody;
    public GameObject script_stone;
    public GameObject script_iron;
    private Following script;
    public Text text;
    public int num = 0;
    public GameObject obj_stone;
    private GameObject obj_iron;
    private void Update()
    {
    }
    private void FixedUpdate()
    {
        FixIron();
        FixStone();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "NewStone")
        {
            float x = rigidbody.position.x;
            float y = (float)1.9;
            float z = rigidbody.position.z;
            if (inventory[4] == null)
            {
                Destroy(collision.gameObject);
                script_stone = collision.gameObject;
                script = script_stone.GetComponent<Following>();
                script.enabled = true;
                cur_object = Instantiate(collision.gameObject, new Vector3(x, y, z - (float)0.2), Quaternion.identity);
                cur_object.name = "InventoryStone";
                for (int i = 0; i < 1; i++)
                {
                    if (inventory[i] == null)
                    {
                        inventory[i] = cur_object;
                    }
                    else if (inventory[i + 1] == null)
                    {
                        inventory[i + 1] = cur_object;
                    }
                    else if (inventory[i + 2] == null)
                    {
                        inventory[i + 2] = cur_object;
                    }
                    else if(inventory[i + 3] == null)
                    {
                        inventory[i + 3] = cur_object;
                    }
                    else if (inventory[i + 4] == null)
                    {
                        inventory[i + 4] = cur_object;
                    }
                }
                num++;
                text.text = "Inventory: " + num;
            }
        }
        if (collision.gameObject.name == "Iron(Clone)")
        {
            float x = rigidbody.position.x;
            float y = (float)1.9;
            float z = rigidbody.position.z;
            if (inventory[4] == null)
            {
                Destroy(collision.gameObject);
                script_iron = collision.gameObject;
                script = script_iron.GetComponent<Following>();
                script.enabled = true;
                cur_object = cur_object = Instantiate(collision.gameObject, new Vector3(x, y, z - (float)0.2), Quaternion.identity);
                cur_object.name = "InventoryIron";
                for (int i = 0; i < 1; i++)
                {
                    if (inventory[i] == null)
                    {
                        inventory[i] = cur_object;
                    }
                    else if (inventory[i + 1] == null)
                    {
                        inventory[i + 1] = cur_object;
                    }
                    else if (inventory[i + 2] == null)
                    {
                        inventory[i + 2] = cur_object;
                    }
                    else if (inventory[i + 3] == null)
                    {
                        inventory[i + 3] = cur_object;
                    }
                    else if (inventory[i + 4] == null)
                    {
                        inventory[i + 4] = cur_object;
                    }
                }
                num++;
                text.text = "Inventory: " + num;
            }
        }
    }
    private void FixStone()
    {
        if (GameObject.Find("InventoryStone(Clone)"))
        {
            obj_stone = GameObject.Find("InventoryStone(Clone)");
            if (obj_stone.name != null)
            {
                Destroy(obj_stone);
            }
        }
        
    }
    private void FixIron()
    {
        if (GameObject.Find("InventoryIron(Clone)"))
        {
            obj_iron = GameObject.Find("InventoryIron(Clone)");
            if (obj_iron.name != null)
            {
                Destroy(obj_iron);
            }
        }

    }
}
