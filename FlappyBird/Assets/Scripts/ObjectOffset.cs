using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOffset : MonoBehaviour
{
    // Start is called before the first frame update

    public float objspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(objspeed * Time.deltaTime, 0f);
    }
}
