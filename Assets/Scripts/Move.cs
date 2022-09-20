using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0.01f;
    private Vector2 destination;
    
    // Start is called before the first frame update
    void Start()
    {
        destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = Vector2.MoveTowards(transform.position, destination, speed);
        transform.position = temp;
        if((Vector2)transform.position == destination)
        {
            if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
            {
                destination = (Vector2)transform.position + Vector2.up;
                GetComponent<AudioSource>().Play();
            }

            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                destination = (Vector2)transform.position + Vector2.down;
                GetComponent<AudioSource>().Play();
            }

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                destination = (Vector2)transform.position + Vector2.left;
                GetComponent<AudioSource>().Play();
            }

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                destination = (Vector2)transform.position + Vector2.right;
                GetComponent<AudioSource>().Play();
            }
            Vector2 cotrol = destination - (Vector2)transform.position;
            GetComponent<Animator>().SetFloat("X", cotrol.x);
            GetComponent<Animator>().SetFloat("Y", cotrol.y);
        }

    }
}
