using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (activeTween != null)
        {
            float time0 = (Time.time - activeTween.StartTime) / activeTween.duration;

            if (Vector2.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
            {
                activeTween.Target.position = Vector2.Lerp(activeTween.StartPos, activeTween.EndPos,time0);
            }
            else
            {
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }
    }
    public void AddTween(Transform targetObject, Vector2 startPos, Vector2 endPos, float duration)
    {
        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
}
