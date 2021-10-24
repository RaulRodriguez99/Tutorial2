using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
          Application.Quit();
        }
    }


    // Update is called once per frame
    void LateUpdate()
    {
      this.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, this.transform.position.z);  
    }
    
}
