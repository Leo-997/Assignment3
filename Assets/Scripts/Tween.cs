using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; set; }
    public Vector2 StartPos { get; set; }
    public Vector2 EndPos { get; set; }
    public float StartTime { get; set; }
    public float Duration { get; set; }


    public Tween(Transform target, Vector2 startPos, Vector2 endPos, float startTime, float duration)
    {
        Target = target;
        StartPos = startPos;
        EndPos = endPos;
        StartTime = startTime;
        Duration = duration;
    }

    public Transform target
    {
        get => Target;
        private set => Target = value;
    }

    public Vector2 startPos
    {
        get => StartPos;
        private set => StartPos = value;
    }

    public Vector2 endPos
    {
        get => EndPos;
        private set => EndPos = value;
    }
    public float startTime
    {
        get => StartTime;
        private set => StartTime = value;
    }
    public float duration
    {
        get => Duration;
        private set => Duration = value;
    }

}
