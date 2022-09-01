using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour

{
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("kills")) {
            Destroy(gameObject);
            levelManager.instance.Respawn();
        }
    }

    private void OnTriggerEnter2D(Collider2D isTrigger) {
        if(isTrigger.gameObject.CompareTag("offMap")) {
            Destroy(gameObject);
            levelManager.instance.Respawn();
        }
    }
}
