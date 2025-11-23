using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldHit : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-7f, 5.5f, 1f);
       if (gameManager.shield == false)
        {
            Destroy(this.gameObject);
        } 
    }
}
