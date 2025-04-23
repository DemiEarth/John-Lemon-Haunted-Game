using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SlowChase : MonoBehaviour
{

    public Transform player;
    public NavMeshAgent agent;
    public MeshRenderer mesh;
    public GameObject sprite;
    public GameObject view;

    // Start is called before the first frame update

    //the transparent enemy's mesh and its children (the sprite renderer and the point of view) are set to inactive at start
    void Start()
    {
        player = GameObject.Find("JohnLemon").transform;
        agent = GetComponent<NavMeshAgent>();
        mesh.enabled=false;
        sprite.SetActive(false);
        view.SetActive(false);
    }

    // Update is called once per frame
    //the Chase() method is called at the start of the game and waits 20 seconds before spawning the enemy
    void Update()
    {
        StartCoroutine(Chase());
    }

    //after 20 seconds, this function starts and everything is set to active. the enemy slowly moves at the player, remains looking at them, and avoids walls. 
    private IEnumerator Chase()
    {
        yield return new WaitForSeconds(73);
        mesh.enabled=true;
        sprite.SetActive(true);
        view.SetActive(true);
        agent.SetDestination(player.position);
        transform.LookAt(player);
    }
}
