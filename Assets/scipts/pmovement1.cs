using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pmovement1 : MonoBehaviour
{
    Vector3 target;
    float x,y;
    float l,r;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            x = Random.Range(-37f, 37f);
            y = Random.Range(-12.5f, 12.5f);
            target = new Vector3(x, y, 0);
            

            Vector3 nm = (target - transform.position).normalized;

            float angle = Mathf.Atan2(nm.y, nm.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(0,0,angle);

            float dis = Vector3.Distance(transform.position,target);
            r = 0.001f/dis;
            l = 0;
        }
        transform.position = Vector3.Lerp(transform.position, target, l);
        l += r;
        
    }
}








//[Range(1,10)]
//public float speed;

//public GameObject target
//Instantiate(target,target.transform.position,Quaternion.identity);