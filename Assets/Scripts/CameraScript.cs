using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraScript : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();
    private float maxY;
    private GameObject score;

    // Start is called before the first frame update
    void Start()
    {
        maxY = this.transform.position.y;
        score = GameObject.FindGameObjectWithTag("Score");
    }

   

    void LateUpdate()
    {

        if(!targetTransform.Equals(null) && maxY < targetTransform.position.y )
        {
            maxY = targetTransform.position.y;
            tempVec3.x = this.transform.position.x;
            tempVec3.y = targetTransform.position.y;
            tempVec3.z = this.transform.position.z;
            this.transform.position = tempVec3;

        }
        score.gameObject.GetComponent<Text>().text = "Score: " + Mathf.RoundToInt(maxY)*10;
        
    }
}
