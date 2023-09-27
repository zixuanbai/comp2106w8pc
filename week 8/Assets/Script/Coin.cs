using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Player player = other.GetComponent<Player>();
            Scorekeeper scorekeeper = FindObjectOfType<Scorekeeper>();
            scorekeeper.CollectCoin(player.player);
            Destroy(this.gameObject);
        }
        
    }
}
