using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public GameObject shieldedPrefab;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if(whatDidIHit.tag == "Player")
        {
            
            
            gameManager.shielded();
            Instantiate(shieldedPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
