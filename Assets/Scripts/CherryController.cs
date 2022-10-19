using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private bool creat = false;
    public GameObject prefab;
    private float gap = 10.0f;
    public GameObject test;
    public Vector2 newPos;
    private Tweener tweener;
    private void Start()
    {
        tweener = GetComponent<Tweener>();
    }
    void Update()
    {

        //λ��
        if (creat)
        {
            float x = Random.Range(-27, -35);
            float y = Random.Range(14, -15);
            
            Vector3 pos = new Vector2(x, y);
            //ʵ����
            test = Instantiate(prefab, pos, Quaternion.identity);
            newPos = new Vector2(-test.transform.position.x, -test.transform.position.y);
            tweener.AddTween(test.transform, test.transform.position, newPos, 5.0f);
            creat = false;
        }
        //���ʱ��
        if (Time.time > gap)
        {
            creat = true;
            gap += 10;

        }

        //�ݻ�
        if (Time.time > gap - 2)
        {
            Destroy(test);
        }

    }
}
