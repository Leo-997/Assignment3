using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentController : MonoBehaviour
{
    [SerializeField] private GameObject pacObj;
    Vector2 destination = Vector2.zero;
    private Tweener tweener;
    string lastInput, currentInput;
    private AudioSource currentClip;
    public AudioClip Moving, Wall,Eatting;
    private ParticleSystem walkParticle;
    private void Awake()
    {
        lastInput = PlayerPrefs.GetString("Key_String", "");
        currentInput = lastInput;
        currentClip = pacObj.GetComponent<AudioSource>();
        walkParticle = pacObj.GetComponentInChildren<ParticleSystem>();
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
            checkInput();
            if ((Vector2)pacObj.transform.position == destination)
            {
                pacObj.GetComponent<AudioSource>().Stop();
                findWall();
            }
        }
    }

    public void checkInput()
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
    }

    public void Move()
    {
        if (lastInput == "A")
        {
            destination = new Vector2(pacObj.transform.position.x - 1, pacObj.transform.position.y);
            tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
            currentClip.clip = Moving;
            currentClip.Play();
            walkParticle.Play();
            pacObj.GetComponent<Animator>().SetFloat("X", -1);
            pacObj.GetComponent<Animator>().SetFloat("Y", 0);

        }

        if (lastInput == "D")
        {
            destination = new Vector2(pacObj.transform.position.x + 1, pacObj.transform.position.y);
            tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
            currentClip.clip = Moving;
            currentClip.Play();
            walkParticle.Play();
            pacObj.GetComponent<Animator>().SetFloat("X", 1);
            pacObj.GetComponent<Animator>().SetFloat("Y", 0);

        }

        if (lastInput == "W")
        {
            destination = new Vector2(pacObj.transform.position.x, pacObj.transform.position.y + 1);
            tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
            currentClip.clip = Moving;
            currentClip.Play();
            walkParticle.Play();
            pacObj.GetComponent<Animator>().SetFloat("X", 0);
            pacObj.GetComponent<Animator>().SetFloat("Y", 1);

        }

        if (lastInput == "S")
        {
            destination = new Vector2(pacObj.transform.position.x, pacObj.transform.position.y - 1);
            tweener.AddTween(pacObj.transform, pacObj.transform.position, destination, 0.7f);
            currentClip.clip = Moving;
            currentClip.Play();
            walkParticle.Play();
            pacObj.GetComponent<Animator>().SetFloat("X", 0);
            pacObj.GetComponent<Animator>().SetFloat("Y", -1);

        }
    }
    public void leftWall()
    {
        RaycastHit left;
        bool leftCheck = Physics.Raycast(pacObj.transform.position, Vector2.left,out left,1.0f);
        if (leftCheck)
        {
            if (left.collider.gameObject.tag == "Wall")
            {
                lastInput = null;
                currentClip.Stop();
                left.collider.gameObject.GetComponent<AudioSource>().clip = Wall;
                left.collider.gameObject.GetComponent<AudioSource>().Play();
                stopAnimation();
            }
            else
            {
                lastInput = "A";
                currentInput = lastInput;
            }
        }
    }
    public void rightWall()
    {
        RaycastHit right;
        bool leftCheck = Physics.Raycast(pacObj.transform.position, Vector2.right, out right, 1.0f);
        if (leftCheck)
        {
            if (right.collider.gameObject.tag == "Wall")
            {
                lastInput = null;
                currentClip.Stop();
                right.collider.gameObject.GetComponent<AudioSource>().clip = Wall;
                right.collider.gameObject.GetComponent<AudioSource>().Play();
                stopAnimation();
            }
            else
            {
                lastInput = "D";
                currentInput = lastInput;
            }
        }
    }
    public void upWall()
    {
        RaycastHit up;
        bool leftCheck = Physics.Raycast(pacObj.transform.position, Vector2.up, out up, 1.0f);
        if (leftCheck)
        {
            if (up.collider.gameObject.tag == "Wall")
            {
                lastInput = null;
                currentClip.Stop();
                up.collider.gameObject.GetComponent<AudioSource>().clip = Wall;
                up.collider.gameObject.GetComponent<AudioSource>().Play();
                stopAnimation();
            }
            else
            {
                lastInput = "W";
                currentInput = lastInput;
            }
        }
    }
    public void downWall()
    {
        RaycastHit down;
        bool leftCheck = Physics.Raycast(pacObj.transform.position, Vector2.down, out down, 1.0f);
        if (leftCheck)
        {
            if (down.collider.gameObject.tag == "Wall")
            {
                lastInput = null;
                currentClip.Stop();
                down.collider.gameObject.GetComponent<AudioSource>().clip = Wall;
                down.collider.gameObject.GetComponent<AudioSource>().Play();
                stopAnimation();
            }
            else
            {
                lastInput = "S";
                currentInput = lastInput;
            }
        }
    }

    public void findWall()
    {
        if(lastInput == "A")
        {
            leftWall();
            Move();
        }
        if (lastInput == "D")
        {
            rightWall();
            Move();
        }
        if (lastInput == "W")
        {
            upWall();
            Move();
        }
        if (lastInput == "S")
        {
            downWall();
            Move();
        }

    }

    public void stopAnimation()
    {
        pacObj.GetComponent<Animator>().SetFloat("X", 1);
        pacObj.GetComponent<Animator>().SetFloat("Y", 1);
    }
}
