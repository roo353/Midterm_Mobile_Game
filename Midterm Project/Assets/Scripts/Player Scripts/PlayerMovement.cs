using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rgbd;
    public Vector3 moveDir;

    public CharacterData characterData;

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody2D>();
        moveDir = new Vector3();
    }

    void Update()
    {
        moveDir.x = Input.GetAxisRaw("Horizontal");
        moveDir.y = Input.GetAxisRaw("Vertical");

        moveDir *= characterData.moveSpeed;

        rgbd.velocity = moveDir;
    }
}
