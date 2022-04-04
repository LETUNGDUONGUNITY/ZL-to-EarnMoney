using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;
public class Zombie : MonoBehaviour
{
    public float q=1.25f;
    [SerializeField]
    private int t;
    [SerializeField]
    private int jumpForce;
    Rigidbody rb;
    LaneRunner runner;
    [SerializeField]
    private Animator _than_cung;
    [SerializeField]
    private BoxCollider _than;
    [SerializeField]
    private Vector3 _kich_co,_trong_tam;
    // Start is called before the first frame update
    void Start()
    {
        runner = GetComponent<LaneRunner>();
        rb = GetComponent<Rigidbody>();
        _than_cung = _than_cung.GetComponent<Animator>();
        _than = _than.GetComponent<BoxCollider>();
        _kich_co = new Vector3(_than.size.x, _than.size.y, _than.size.z);
        _trong_tam = new Vector3(_than.center.x, _than.center.y, _than.center.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            runner.lane--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            runner.lane++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _than_cung.Play("skel_king_jump 0");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            StartCoroutine(_lon_nhao(t));
        }    
    }
    IEnumerator _lon_nhao(int t)
    {
        _than.size = new Vector3(_kich_co.x, 0.1f,_kich_co.z);
        _than.center = new Vector3(_trong_tam.x, 0.2f,_trong_tam.z);
        yield return new WaitForSeconds(t);
        _than.size = _kich_co;
        _than.center = _trong_tam;
    } 
     
}
