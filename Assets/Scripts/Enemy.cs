using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody2D rigid;
    Collider2D groundCheckColl;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        groundCheckColl = transform.GetChild(0).GetComponent<Collider2D>();
    }

    private void FixedUpdate()//default, 0.02√ 
    {
        if (groundCheckColl.IsTouchingLayers(LayerMask.GetMask("Ground")) == false)
        {
            flip();
        }
    }

    private void flip()
    {
        speed *= -1;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void Update()
    {
        rigid.velocity = new Vector2(speed, rigid.velocity.y);
    }
}
