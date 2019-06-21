using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathzoneScript : MonoBehaviour
{

    public GameObject player;
    public GameObject Platform;
    public GameObject PlatformGoingLeft;
    public GameObject PlatformGoingRight;
    private GameObject myPlat;
    public GameObject retryBtn;

    // Start is called before the first frame update
    void Start()
    {
        retryBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            myPlat = (GameObject)Instantiate(Platform, new Vector2(Random.Range(-3f, 3f), player.transform.position.y + (7f + Random.Range(-0.1f, 0.5f))), Quaternion.identity);
            Destroy(collision.gameObject);

        }else if(collision.gameObject.tag == "PlatformLeft")
        {
            myPlat = (GameObject)Instantiate(PlatformGoingLeft, new Vector2(Random.Range(-7f, 7f), player.transform.position.y + (7f + Random.Range(-0.1f, 0.5f))), Quaternion.identity);
            Destroy(collision.gameObject);
        }else if (collision.gameObject.tag == "PlatformRight")
        {
            myPlat = (GameObject)Instantiate(PlatformGoingRight, new Vector2(Random.Range(-7f, 7f), player.transform.position.y + (7f + Random.Range(-0.1f, 0.5f))), Quaternion.identity);
            Destroy(collision.gameObject);
        }else if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            retryBtn.SetActive(true);
        }

    }
}
