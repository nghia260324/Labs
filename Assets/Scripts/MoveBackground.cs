using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public GameObject background;
    public GameObject posStart;
    public GameObject posEnd;
    public float speed;

    private void Update()
    {
        background.transform.position = Vector2.MoveTowards(posEnd.transform.position,
            posStart.transform.position, speed * Time.deltaTime);
    }
}
