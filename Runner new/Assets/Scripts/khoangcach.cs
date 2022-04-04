using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khoangcach : MonoBehaviour
{
    public Transform mm;
    
    // Start is called before the first frame update
    Transform[] allchild;
    void Start()
    {
        allchild = this.transform.GetComponentsInChildren<Transform>();
        // allchild = this.transform.GetComponentInChildren<Transform[]>();
      

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
