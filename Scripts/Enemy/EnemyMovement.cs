using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    NavMeshAgent nav;
	public float juli;


    void Awake ()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <NavMeshAgent> ();
    }


    void Update ()
    {
				//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
				//{
				//    nav.SetDestination (player.position);
				//}
				//else
				//{
				//    nav.enabled = false;
				//}
				float distance = (player.position - transform.position).magnitude;
				bool chase = false;

				if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0) {
						if (distance <= juli) {
								chase = true;
						} else {
								chase = false;
						}
						if (chase == true) {
								nav.SetDestination (player.position);
						} else {
								Vector3 position = new Vector3 (Random.value, Random.value, Random.value);
								nav.SetDestination (position);
						}


				}else{
			nav.enabled = false;
	}
}
}
