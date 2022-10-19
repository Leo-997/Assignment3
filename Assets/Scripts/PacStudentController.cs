using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    [SerializeField] private GameObject pacObj;
    Vector2 destination = Vector2.zero;
    private Tweener tweener;
    string lastInput;
    private void Awake()
    {
        lastInput = PlayerPrefs.GetString("Key_String", "");
        Debug.Log(lastInput);
    }
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
        destination = (Vector2)pacObj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (pacObj != null && tweener != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                PlayerPrefs.SetString("Key_String", "A");
                lastInput = PlayerPrefs.GetString("Key_String", "");
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                PlayerPrefs.SetString("Key_String", "D");
                lastInput = PlayerPrefs.GetString("Key_String", "");
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                PlayerPrefs.SetString("Key_String", "W");
                lastInput = PlayerPrefs.GetString("Key_String", "");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                PlayerPrefs.SetString("Key_String", "S");
                lastInput = PlayerPrefs.GetString("Key_String", "");
            }
            if ((Vector2)pacObj.transform.position == destination)
            {
                
                pacObj.GetComponent<AudioSource>().Stop();
                if (lastInput == "A")
                {
                    destination = new Vector2(pacObj.transform.position.x - 1, pacObj.transform.position.y);
                    tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
                    pacObj.GetComponent<AudioSource>().Play();
                    pacObj.GetComponent<Animator>().SetFloat("X", -1);
                    pacObj.GetComponent<Animator>().SetFloat("Y", 0);
                    
                }

                if (lastInput == "D")
                {
                    destination = new Vector2(pacObj.transform.position.x + 1, pacObj.transform.position.y);
                    tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
                    pacObj.GetComponent<AudioSource>().Play();
                    pacObj.GetComponent<Animator>().SetFloat("X", 1);
                    pacObj.GetComponent<Animator>().SetFloat("Y", 0);
                   
                }

                if (lastInput == "W")
                {
                    destination = new Vector2(pacObj.transform.position.x, pacObj.transform.position.y + 1);
                    tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
                    pacObj.GetComponent<AudioSource>().Play();
                    pacObj.GetComponent<Animator>().SetFloat("X", 0);
                    pacObj.GetComponent<Animator>().SetFloat("Y", 1);
                    
                }

                if (lastInput == "S")
                {
                    destination = new Vector2(pacObj.transform.position.x, pacObj.transform.position.y - 1);
                    tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
                    pacObj.GetComponent<AudioSource>().Play();
                    pacObj.GetComponent<Animator>().SetFloat("X", 0);
                    pacObj.GetComponent<Animator>().SetFloat("Y", -1);
                    
                }
               
            }
        }
    }
}
