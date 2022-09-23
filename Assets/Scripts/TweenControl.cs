using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenControl : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject pacObj;
    private Tweener tweener;

    void Start()
    {
        tweener = GetComponent<Tweener>();

    }

    // Update is called once per frame
    void Update()
    {
        if (pacObj.transform.position.x == -9.7f && pacObj.transform.position.y == 13.55f)
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(-4.7f, 13.55f), 1.5f);
            pacObj.GetComponent<Animator>().SetFloat("X", 1);
            pacObj.GetComponent<Animator>().SetFloat("Y", 0);
            pacObj.GetComponent<AudioSource>().Play();
        }

        if (pacObj.transform.position.x == -4.7f && pacObj.transform.position.y == 13.55f)
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(-4.7f, 9.55f), 1.5f);
            pacObj.GetComponent<Animator>().SetFloat("X", 0);
            pacObj.GetComponent<Animator>().SetFloat("Y", -1);
            pacObj.GetComponent<AudioSource>().Play();
        }

        if (pacObj.transform.position.x == -4.7f && pacObj.transform.position.y == 9.55f)
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(-9.7f, 9.55f), 1.5f);
            pacObj.GetComponent<Animator>().SetFloat("X", -1);
            pacObj.GetComponent<Animator>().SetFloat("Y", 0);
            pacObj.GetComponent<AudioSource>().Play();
        }

        if (pacObj.transform.position.x == -9.7f && pacObj.transform.position.y == 9.55f)
        {
            tweener.AddTween(pacObj.transform, pacObj.transform.position, new Vector2(-9.7f, 13.55f), 1.5f);
            pacObj.GetComponent<Animator>().SetFloat("X", 0);
            pacObj.GetComponent<Animator>().SetFloat("Y", 1);
            pacObj.GetComponent<AudioSource>().Play();

        }


    }
}
