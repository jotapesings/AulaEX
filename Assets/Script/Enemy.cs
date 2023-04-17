using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform _pos;
    [SerializeField] Vector3 _motion;

    // Start is called before the first frame update
    void Start()
    {
        _pos.localScale = new Vector3(10,2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
