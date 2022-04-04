using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dreamteck.Forever;
using UnityEngine.UI;
public class TungDuongplayer : MonoBehaviour
{
    public GameObject[] _camera_man;
    [SerializeField]
    private Animator _king;
    public int _gia_toc;
    public int _diem_so_0=0;
    [SerializeField]
    private Rigidbody rb;
    public int jumpForce;
    LaneRunner runner;
    [SerializeField]
    private GameObject level;
    public bool v;
    void Start()
    {

        _king = _king.GetComponent<Animator>();
    //    rb = GetComponent<Rigidbody>();
        runner = GetComponent<LaneRunner>();
        rb = rb.GetComponent<Rigidbody>();
        _king.Play("skel_king_laugh");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (level.transform.childCount >= 2&&v==false)
        {
            _king.Play("skel_king_run");
            
            v = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _king.Play("skel_king_gethit1");
            runner.lane--;
        }
         if(Input.GetKeyDown(KeyCode.RightArrow))   
        {
            _king.Play("skel_king_gethit2");
            runner.lane++;
        }
         
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            _king.Play("skel_king_jump");   
            rb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
        }
        }
    
    
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("vc"))
        {
            runner.follow = false;
            Debug.Log("Finish");
            _king.Play("skel_king_die");
            ShowCam(3);
        }
    }

    public void ShowCam(int i)
    {
        for(int j=1;j<=4;j++)
        {
            if (j == i) _camera_man[j].SetActive(true);
            else _camera_man[j].SetActive(false);
        }
    }
}
