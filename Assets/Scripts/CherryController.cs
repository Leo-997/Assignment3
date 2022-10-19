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
    private float localTime;
    private void Start()
    {
        tweener = GetComponent<Tweener>();
    }
    void Update()
    {
        localTime += Time.deltaTime;
        if (localTime > gapTime)
        {
            creatPrefab = true;
            gapTime += 10;
            Creat();
        }
        if (test)
        {
            if (localTime > gapTime - 1)
            {
                Destroy(test);
            }
        }

    }
    public void Creat()
    {
        if (creatPrefab)
        {
            float x = Random.Range(-27, -35);
            float y = Random.Range(14, -15);
            Vector2 pos = new Vector2(x, y);
            test = Instantiate(prefab, pos, Quaternion.identity);
            newPos = -pos;
            tweener.AddTween(test.transform, test.transform.position, newPos, 8.5f);
            creatPrefab = false;
        }
    }
}
