using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxtime;
    public float curtime = 0;
    public GameObject obstacle;
    public float height;

    private void Start()
    {
        GameObject newobstacle = Instantiate(obstacle);
        newobstacle.transform.position = new Vector2(0, transform.position.y + Random.Range(-height, height));
    }
    private void Update()
    {
        if (curtime > maxtime) {
            GameObject newobstacle = Instantiate(obstacle);
            newobstacle.transform.position = new Vector2(0, transform.position.y + Random.Range(-height, height));
            curtime = 0;
        }
        curtime = curtime + Time.deltaTime;
    }
}
