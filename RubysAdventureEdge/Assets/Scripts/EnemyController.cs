using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y = rigidbody2D.position;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed;
        }
        rigidbody2D.MovePosition(position)
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
