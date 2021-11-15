using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IAController : MonoBehaviour
{
    public int time;
    public float speed = 5f;
    float y;
    public bool rotime;
    public bool Attack;
    public bool idle;
    public NavMeshAgent agent;
    public Animator anim;

    public int state = 1;

    void FixedUpdate()
    {
        time += 1;
        if (state == 1)
        {
            Attack = true;
            idle = false;
        }
        else if (state == 2)
        {
            Attack = false;
            idle = true;
        }
        if (idle == true)
        {
            transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
            transform.Rotate(new Vector3(0, y, 0));
            anim.SetBool("Idle",true);
            if (time >= Random.Range(200, 2500))
            {
                Rotatar();
                rotime = true;
                time = 0;
            }
            if (rotime == true)
            {
                if (time >= Random.Range(15, 40))
                {
                    y = 0;
                    rotime = false;
                }
            }
        }
        else if (Attack == true)
        {
            agent.SetDestination(GameObject.FindGameObjectWithTag("Player").transform.position);
            if (Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, transform.position) > 30)
            {
                state = 1;
            }
        }
    }
    public void Rotatar()
    {
        y = Random.Range(-3, 3);
    }
}
