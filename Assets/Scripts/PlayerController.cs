using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour
{
    //Передвижение игрока с помощью джостика 
    [SerializeField]
    private Camera camera;
    [SerializeField]
    private Rigidbody rigidbody;
    [SerializeField]
    private FixedJoystick joystick;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private float speed;
    private int state;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(joystick.Horizontal * speed, rigidbody.velocity.y, joystick.Vertical * speed);
        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            //transform.rotation = Quaternion.LookRotation(rigidbody.velocity);
            rigidbody.rotation = Quaternion.LookRotation(rigidbody.velocity);
            state = 1;
        }
        else
        {
            state = 0;
        }
        animator.SetInteger("state", state);
    }
}
