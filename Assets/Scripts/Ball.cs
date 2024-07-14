using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BallColor
{
    White,
    Red,
    Yellow,
    Green,
    Brown,
    Blue,
    Pink,
    Black
}

public class Ball : MonoBehaviour
{
    [SerializeField]
    private int point;

    [SerializeField]
    private BallColor color;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(point);
    }
}
