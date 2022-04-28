using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Referenciando o Rigidbody para manipular a física
    private Rigidbody2D rig;

    public float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        // Se não apertar nada, retorna 0. Se pressionar direita, retorna 1. Se pressionar esquerda, retorna -1.
        float movement = Input.GetAxis("Horizontal");

        rig.velocity = new Vector2(movement * speed, rig.velocity.y);

        if(movement > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if(movement < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

}
