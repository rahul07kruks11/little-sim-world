using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float force = 10f;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        //rigid.MovePosition(rigid.position + movement * force * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        rigid.MovePosition(rigid.position + movement * force * Time.deltaTime);
    }
}
