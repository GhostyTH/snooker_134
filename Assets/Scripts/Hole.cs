using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Ball B = collision.gameObject.GetComponent<Ball>();

        if (B != null)
        {
            GameManager.instance.UpdateScore(B.Point);
            Destroy(B.gameObject);
        }
    }
}