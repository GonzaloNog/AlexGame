using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boot : MonoBehaviour
{
    public GameObject target;
    private float speed = 3.0f;
    private Animator anim;
    // Update is called once per frame
    void Awake()
    {
        transform.position = new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z);
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Vector3 targetPoint = new Vector3(target.transform.position.x, this.transform.position.y, target.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPoint , speed * Time.deltaTime);
        if(transform.position == targetPoint)
        {
            anim.SetBool("Walk_Anim", false);
        }
        else
            anim.SetBool("Walk_Anim", true);
    }
}
