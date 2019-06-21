using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathzoneLeftScript : MonoBehaviour
{

    public GameObject Platform;
    private GameObject myPlat;
    public float location = 10.42f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlatformLeft" || collision.gameObject.tag == "PlatformRight")
        {
            myPlat = (GameObject)Instantiate(Platform, new Vector2(location, collision.transform.position.y ), Quaternion.identity);
            Destroy(collision.gameObject);
        }

    }
}
