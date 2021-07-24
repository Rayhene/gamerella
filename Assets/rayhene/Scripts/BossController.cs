using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms;
using Random = UnityEngine.Random;

public class BossController : MonoBehaviour
{
    public float speed;
    public float attackRadius;
    
    public bool shouldRotate;
    public LayerMask whatIsPlayer;
    
    public Rigidbody2D rb;
    public Animator animator;

    private Transform target;
    private Vector2 movement; 
    public Vector3 direction;

    private bool isInChaseRange;
    private bool isInAttackRange;

    public FieldOfView fieldOfView;

    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    public int randomSpot;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        fieldOfView = GetComponent<FieldOfView>();

        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);

        //target = GameObject.FindWithTag("player").transform;

    }

    void Update()
    {   
        /*
        isInChaseRange = fieldOfView.FindVisibleTargets();
        animator.SetBool("isRunning", isInChaseRange);
        isInAttackRange = Physics2D.OverlapCircle(transform.position, attackRadius, whatIsPlayer);
        
        direction = (target.position - transform.position).normalized;
        
        movement = direction;

        if (shouldRotate)
        {
            animator.SetFloat("X", direction.x);
            animator.SetFloat("Y", direction.y);
        }*/
    }
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
        /*
        if (isInChaseRange && !isInAttackRange)
        {
            MoveBoss(movement);
        }

        if (isInAttackRange)
        {
            print("entrou no range de ataque");
            rb.velocity = Vector2.zero;
            
        }*/

    }
    private void MoveBoss(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
    
    

}