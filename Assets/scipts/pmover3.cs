using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class pmover3 : MonoBehaviour
{

    public GameObject pobject;
    public GameObject endpoints;
   // public GameObject way;
    public int pathpoints;
    public Vector2 Startpoint;
    public Vector2 Endpoint;
    Vector2[] path;
    float pathvalue;
    float speed;
    public float time;
    int k = 0;
    float t = 0;

    // Start is called before the first frame   
    void Start()
    {

        path = new Vector2[pathpoints];
        path[0] = new Vector2(Mathf.Clamp(Startpoint.x,-7,7), Mathf.Clamp(Startpoint.y,-2,2));
        path[pathpoints - 1] = new Vector2(Mathf.Clamp(Endpoint.x,-7,7), Mathf.Clamp(Endpoint.y,-2,2));

        pobject.transform.position = path[0];

        Instantiate(endpoints, path[0], Quaternion.identity);
        Instantiate(endpoints, path[pathpoints - 1], Quaternion.identity);

        for (int i = 1; i < pathpoints - 1; i++)
        {
            float x = Random.Range(-7, 7);
            float y = Random.Range(-2, 2);
            path[i] = new Vector2(x, y);
            Instantiate(endpoints, path[i], Quaternion.identity);
            pathvalue += Vector2.Distance(path[i], path[i-1]);
        }
        pathvalue += Vector2.Distance(path[pathpoints - 2], path[pathpoints - 1]);
        speed = pathvalue / time;
    }

    // Update is called once per frame
    void Update()
    {
        if (k < pathpoints - 1)
        {
            float pathsection = Vector2.Distance(path[k], path[k+1]);
            float timesection = pathsection / speed;
            t += Time.deltaTime/timesection;
            pobject.transform.position = Vector2.Lerp(path[k], path[k + 1], t);
            //Instantiate(way, pobject.transform.position, Quaternion.identity);

            if (t >= 1)
            {
                k++;
                t = 0;
            }
        }
    }
}


















//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using UnityEngine;

//public class pmover3 : MonoBehaviour
//{

//    public GameObject pobject;
//    public GameObject endpoints;
//    public int pathpoints;
//    public Vector2 Startpoint;
//    public Vector2 Endpoint;
//    Vector3[] path;
//    float pathvalue;
//    float speed;
//    public float time;
//    int k = 0;
//    float t = 0;

//    // Start is called before the first frame   
//    void Start()
//    {

//        path = new Vector3[pathpoints];
//        path[0] = new Vector3(Startpoint.x, Startpoint.y, 0);
//        path[pathpoints - 1] = new Vector3(Endpoint.x, Endpoint.y, 0);

//        pobject.transform.position = path[0];

//        Instantiate(endpoints, path[0], Quaternion.identity);
//        Instantiate(endpoints, path[pathpoints - 1], Quaternion.identity);

//        for (int i = 1; i < pathpoints - 1; i++)
//        {
//            float x = Random.Range(-7, 7);
//            float y = Random.Range(-2, 2);
//            path[i] = new Vector3(x, y, 0);
//            Instantiate(endpoints, path[i], Quaternion.identity);
//            pathvalue += Vector3.Distance(path[i], path[i - 1]);
//        }
//        pathvalue += Vector3.Distance(path[pathpoints - 2], path[pathpoints - 1]);
//        speed = pathvalue / time;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (k < pathpoints - 1)
//        {
//            float pathsection = Vector3.Distance(path[k], path[k + 1]);
//            float timesection = pathsection / speed;
//            t += Time.deltaTime / timesection;
//            pobject.transform.position = Vector3.Lerp(path[k], path[k + 1], t);

//            if (t >= 1)
//            {
//                k++;
//                t = 0;
//            }
//        }
//    }
//}










//if (pobject.transform.position != Ending)
//{
//    float t = 1 - (time - Time.time) / time;
//    pobject.transform.position = Vector3.Slerp(Starting, Ending, t);
//}

//if (pobject.transform.position != path[pathpoints - 1])
//{

//    if (pobject.transform.position != path[i + 1])
//    {
//        //float t = 1 - (time - Time.time) / time;
//        pobject.transform.position = Vector3.MoveTowards(path[i], path[i + 1], speed);
//    }
//    else
//    {
//        //time -= Time.deltaTime;
//        i++;
//    }
//}

//Vector3 Starting;
//Vector3 Ending;



//Starting = new Vector3(Startpoint.x, Startpoint.y, 0);
//Ending = new Vector3(Endpoint.x, Endpoint.y, 0);
//Instantiate(twoendpoints, Starting, Quaternion.identity);
//Instantiate(twoendpoints, Ending, Quaternion.identity);
//pobject.transform.position = Starting;




//public GameObject pobject;
//public GameObject endpoints;
//public int pathpoints;
//Vector3[] path;
//public Vector2 Startpoint;
//public Vector2 Endpoint;
////float speed = 1.0f;
//public float time;
//float t;
//int i = 0;

//if (a)
//{
//    if (pobject.transform.position != path[pathpoints - 1])
//    {
//        if (pobject.transform.position != path[i + 1])
//        {

//            pobject.transform.position = Vector3.Lerp(path[i], path[i + 1], Time.time / time);
//            // t += 0.005f;
//        }
//        else
//        {
//            i++;
//            //t = 0;
//        }
//    }
//    else
//    {
//        pobject.transform.position = Vector3.Slerp(path[pathpoints - 1], path[0], t);
//        t += 0.005f;

//        if (t == 1)
//        {
//            a = false;
//        }
//    }
//}





//public class pmover3 : MonoBehaviour
//{

//    public GameObject pobject;
//    public GameObject endpoints;
//    public int pathpoints;
//    public Vector2 Startpoint;
//    public Vector2 Endpoint;
//    Vector3[] path;
//    float pathvalue;
//    float speed;
//    public float time;
//    float[] timesection;
//    float[] dis;
//    int i = 0;
//    float t;

//    // Start is called before the first frame   
//    void Start()
//    {

//        path = new Vector3[pathpoints];
//        path[0] = new Vector3(Startpoint.x, Startpoint.y, 0);
//        path[pathpoints - 1] = new Vector3(Endpoint.x, Endpoint.y, 0);

//        pobject.transform.position = path[0];

//        Instantiate(endpoints, path[0], Quaternion.identity);
//        Instantiate(endpoints, path[pathpoints - 1], Quaternion.identity);

//        pathvalue = Vector3.Distance(path[0], path[1]);

//        dis = new float[pathpoints - 1];
//        dis[0] = pathvalue;

//        for (i = 1; i < pathpoints - 1; i++)
//        {
//            float x = Random.Range(-7, 7);
//            float y = Random.Range(-2, 2);
//            path[i] = new Vector3(x, y, 0);
//            Instantiate(endpoints, path[i], Quaternion.identity);
//            pathvalue += Vector3.Distance(path[i], path[i + 1]);
//            dis[i] = Vector3.Distance(path[i], path[i + 1]);
//        }
//        speed = time / pathvalue;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (i < pathpoints - 1)
//        {
//            timesection[i] = dis[i] / speed;
//            t += Time.deltaTime;
//            pobject.transform.position = Vector3.Slerp(path[i], path[i + 1], t);

//            if (t >= timesection[i])
//            {
//                t = 0;
//                i++;
//            }
//        }
//    }
//}