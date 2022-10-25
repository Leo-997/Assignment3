using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Transform backDoor;
    private Transform pacStudent;
    private bool isDoor;
    // Start is called before the first frame update
    void Start()
    {
        pacStudent = GameObject.Find("PacStudent").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("����");
        isDoor = true;
        if (other.gameObject.CompareTag("PacStudent"))
        {
            Debug.Log("����");
            isDoor = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("PacStudent"))
        {
            Debug.Log("����");
            isDoor = false;
        }
    }
}
