using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vacham1 : MonoBehaviour
{
    public GameObject mn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        mn = col.gameObject;
        Debug.Log(col);
    }
}
