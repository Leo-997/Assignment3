using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    [SerializeField] private GameObject pacObj;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(pacObj.transform.position.x-1, pacObj.transform.position.y), 1.5f);
            pacObj.GetComponent<AudioSource>().Play();
            pacObj.GetComponent<Animator>().SetFloat("X", -1);
            pacObj.GetComponent<Animator>().SetFloat("Y", 0);
            PlayerPrefs.SetString("Key_String","A");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(pacObj.transform.position.x + 1, pacObj.transform.position.y), 1.5f);
            pacObj.GetComponent<AudioSource>().Play();
            pacObj.GetComponent<Animator>().SetFloat("X", 1);
            pacObj.GetComponent<Animator>().SetFloat("Y", 0);
            PlayerPrefs.SetString("Key_String", "D");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(pacObj.transform.position.x, pacObj.transform.position.y + 1), 1.5f);
            pacObj.GetComponent<AudioSource>().Play();
            pacObj.GetComponent<Animator>().SetFloat("X", 0);
            pacObj.GetComponent<Animator>().SetFloat("Y", 1);
            PlayerPrefs.SetString("Key_String", "W");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(pacObj.transform.position.x, pacObj.transform.position.y - 1), 1.5f);
            pacObj.GetComponent<AudioSource>().Play();
            pacObj.GetComponent<Animator>().SetFloat("X", 0);
            pacObj.GetComponent<Animator>().SetFloat("Y", -1);
            PlayerPrefs.SetString("Key_String", "S");
        }
    }
}