using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggermonstro : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject monstro;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            monstro.SetActive(true);
        }
    }

    

}
