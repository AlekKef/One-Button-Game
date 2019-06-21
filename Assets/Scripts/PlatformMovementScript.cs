using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float movingspeed = 0;
    public float scoremod = 1;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        if (!GameObject.FindGameObjectWithTag("Player").Equals(null))
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            scoremod = 1 + 0.1f * Mathf.RoundToInt(player.position.y / 10);
        }
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity += new Vector2(-movingspeed * scoremod, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
