using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    Pause ps;
    public PointsCanvas pc;
    public ShowLastScore sls;
    public int n;
    public int n1;
    private void OnTriggerEnter2D(Collider2D col)
    {
        
            if (col.gameObject.CompareTag("pointc"))
            {
                
                n++;
                Debug.Log(n);
            pc.text.text = n.ToString();
            sls.textm.text = n.ToString();
        }
        //n1 = n;
        if (col.gameObject.CompareTag("obstacle"))
        {
            sls.textm.text = n.ToString();
            
        }
    }
    
    void Update()
    {
        
    }
}
