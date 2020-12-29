using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("移動速度"), Range(0, 50)]
    public float speed = 3;

    [Header("停止距離"), Range(0, 50)]
    public float stopDistance = 1.2f;

    private Transform player;
    private NavMeshAgent nav;
    private Animator ani;

    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();

        player = GameObject.Find("小明").transform;


        nav.speed = speed;
        nav.stoppingDistance = stopDistance;
    }
    private void Update()
    {
        Track();
    }
    private void Track()
    {
        nav.SetDestination(player.position);

        //print("剩餘距離" + nav.remainingDistance);
        ani.SetBool("跑步開關",nav.remainingDistance>stopDistance);
    }
}
