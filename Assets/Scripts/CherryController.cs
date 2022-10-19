using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private bool creatPrefab = false;
    public GameObject prefab;
    private float gapTime = 10.0f;
    public GameObject test;
    public Vector2 newPos;
    private Tweener tweener;
    private void Start()
    {
        tweener = GetComponent<Tweener>();
    }
    void Update()
    {

        if (creatPrefab)
        {
            float x = Random.Range(-27, -35);
            float y = Random.Range(14, -15);
            Vector2 pos = new Vector2(x, y);
            test = Instantiate(prefab, pos, Quaternion.identity);
            newPos = new Vector2(-test.transform.position.x, -test.transform.position.y);
            tweener.AddTween(test.transform, test.transform.position, newPos, 7.0f);
            creatPrefab = false;
        }
        if (Time.time > gapTime)
        {
            creatPrefab = true;
            gapTime += 10;

        }

        if (Time.time > gapTime - 2)
        {
            Destroy(test);
        }

    }
}
