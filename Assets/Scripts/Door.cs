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

    public void leftDoor()
    {
        RaycastHit left;
        bool leftCheck = Physics.Raycast(pacStudent.transform.position, Vector2.left, out left, 1.0f);
        if (left.collider.gameObject.tag == "Door")
        {
            Debug.Log("进了");
            isDoor = true;
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("进了");
    //    isDoor = true;
    //    if (other.gameObject.CompareTag("PacStudent"))
    //    {
    //        Debug.Log("进了");
    //        isDoor = true;
    //    }
    //}
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("PacStudent"))
    //    {
    //        Debug.Log("出了");
    //        isDoor = false;
    //    }
    //}

    void EnterDoor()
    {
        if (isDoor)
        {
            pacStudent.transform.position = backDoor.position;
        }
    }
}
