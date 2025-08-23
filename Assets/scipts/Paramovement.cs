//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Paramovement : MonoBehaviour
//{

//    public GameObject pobject;
//    public GameObject twoendpoints;
//    public Vector3 Starting;
//    public Vector3 Ending;
//    public float time;
//    // Start is called before the first frame update
//    void Start()
//    {
//        Instantiate(twoendpoints, Starting, Quaternion.identity);
//        Instantiate(twoendpoints, Ending, Quaternion.identity);
//        pobject.transform.position = Starting;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (pobject.transform.position != Ending)
//        {
//            float t = 1 - (time - Time.time) / time;
//            pobject.transform.position = Vector3.Slerp(Starting, Ending, t);
//        }
//    }
//}












using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paramovement : MonoBehaviour
{

    public GameObject pobject;
    public GameObject twoendpoints;
    public Vector3 Starting;
    public Vector3 Ending;
    Vector3 center;
    public float time;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(twoendpoints, Starting, Quaternion.identity);
        Instantiate(twoendpoints, Ending, Quaternion.identity);
        pobject.transform.position = Starting;
    }

    // Update is called once per frame
    void Update()
    {
        if (pobject.transform.position != Ending)
        {
            t += Time.deltaTime / time;
            pobject.transform.position = Vector3.Slerp(Starting, Ending, t);
        }
    }
}










//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor;
//using UnityEngine;

//public class Paramovement : MonoBehaviour
//{

//    public GameObject pobject;
//    public GameObject twoendpoints;
//    public Vector3 Starting;
//    public Vector3 Ending;
//    public float time;
//    Vector3 Center;
//    //float a, b, c;
//    float t = 0;

//    // Start is called before the first frame update
//    void Start()
//    {
//        transform.Translate(Starting.x, Starting.y, Starting.z);
//        Instantiate(twoendpoints, Starting, Quaternion.identity);
//        Instantiate(twoendpoints, Ending, Quaternion.identity);
//        pobject.transform.position = Starting;
//        Center.x = (Ending.x + Starting.x) / 2;
//        Center.y = (Ending.y + Starting.y) / 2;
//        Center.z = (Ending.z + Starting.z) / 2;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //if (transform.position != Center)
//        if(t <= 1)
//        {
//            //a += Ending.x / 100;
//            //b += Ending.z / 100;
//            //c += Ending.y / 100;
//            transform.position = Vector3.Lerp(Starting,Ending,t);
//            t += 0.001f;
//           // pobject.transform.Translate(a, c, b);
//        }
//    }
//}


//using UnityEngine;
//using System.Collections;

//public class Paramovement : MonoBehaviour
//{
//    public Vector3 starting;
//    public Vector3 ending;
//    public float time;

//    void Start()
//    {

//    }

//    void Update()
//    {
//        Vector3 center = (starting + ending) * 0.5F;

////        center -= new Vector3(0, 1, 0);

//        Vector3 a = starting - center;
//        Vector3 b = ending - center;
//        float t = Time.time/ time;
//        transform.position = Vector3.Slerp(a, b, t);
//        transform.position += center;
//    }
//}

