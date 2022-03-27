using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Base : MonoBehaviour
{
    public GameObject[] inventory = new GameObject[100];
    public GameObject aluminum;
    private GameObject cur_object;
    public Rigidbody user;
    private PlayerInventory player;
    public Text inven;
    private int stone = 0;
    private int iron = 0;
    private int al = 0;
    private void FixedUpdate()
    {
        if (stone >= 3 && iron >= 1)
        {
            cur_object = Instantiate(aluminum, new Vector3(3, 3, 3), Quaternion.identity);
            cur_object.name = "Aluminium";
            stone -= 3;
            iron -= 1;
            al++;
            TextMesh text = GameObject.Find("MsgBase").GetComponent<TextMesh>();
            text.text = "Stone: " + stone + " Iron: " + iron + " Aluminium: " + al;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "InventoryStone" || collision.gameObject.name == "InventoryIron")
        {
            if (collision.gameObject.name == "InventoryStone")
            {
                stone++;
                TextMesh text = GameObject.Find("MsgBase").GetComponent<TextMesh>();
                text.text = "Stone: " + stone + " Iron: " + iron + " Aluminium: " + al;
                player = user.gameObject.GetComponent<PlayerInventory>();
                player.num--;
                inven.text = "Inventory: " + player.num;
            }
            if (collision.gameObject.name == "InventoryIron")
            {
                iron++;
                TextMesh text = GameObject.Find("MsgBase").GetComponent<TextMesh>();
                text.text = "Stone: " + stone + " Iron: " + iron + " Aluminium: " + al;
                player = user.gameObject.GetComponent<PlayerInventory>();
                player.num--;
                inven.text = "Inventory: " + player.num;
            }
            Destroy(collision.gameObject);
        }
    }
}
