using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IAController : MonoBehaviour
{
    public int time;
    public float vel;
    public GameObject target;
    public NavMeshAgent agent;
    public float distance;
    bool timerotate;
    public bool idle;
    float y;
    private void FixedUpdate()
    {
        time += 1;
        if (idle)
        {
            transform.Translate(transform.forward * vel * Time.fixedDeltaTime);
            transform.Rotate(new Vector3(0, y, 0));
            if (time >= Random.Range(100, 2500))
            {
                Rotate();
                time = 0;
                timerotate = true;
            }
            if (timerotate == true)
            {
                if (time >= Random.Range(50, 100))
                {
                    y = 0;
                    timerotate = false;
                }
            }
        }
        if (Vector3.Distance(target.transform.position, transform.position) < distance)
        {
            idle = false;
            agent.SetDestination(target.transform.position);
            agent.speed = 3;
        }
        else
        {
            idle = true;
            agent.speed = 0;
        }
    }
    public void Rotate()
    {
        y = Random.Range(-3, 3);
    }
}