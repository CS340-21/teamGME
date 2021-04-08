using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public int hurtGen;
    public GameObject theFlash;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            enemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("Z_Walk_InPlace");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("Attack");
            StartCoroutine(InflictDamage());
        }
    }
        void OnTriggerEnter() {
            attackTrigger = true;
        }
        void OnTriggerExit() {
            attackTrigger = false;
        }
        IEnumerator InflictDamage() {
            isAttacking = true;
            yield return new WaitForSeconds(0.1f);
            GlobalHealth.currentHealth -= 5;
            hurtGen = Random.Range(1,4);
        if (hurtGen == 1) {
            hurtSound1.Play();
        }
        if (hurtGen == 2)
        {
            hurtSound2.Play();
        }
        if (hurtGen == 3)
        {
            hurtSound3.Play();
        }
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        theFlash.SetActive(false);
        yield return new WaitForSeconds(0.35f);
            isAttacking = false;

        }
    
}
