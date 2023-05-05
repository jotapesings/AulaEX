using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CondicionalCombinadas : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] Rigidbody _cubeRig;
    [SerializeField] BoxCollider _cubeBox;

    [SerializeField] GameObject _sphere;
    [SerializeField] Rigidbody _sphereRig;

    [SerializeField] GameObject _cylinder;
    [SerializeField] Rigidbody _cylinderRig;

    [SerializeField] string _Text;
    [SerializeField] float _numero;
    [SerializeField] bool _check;

    // Start is called before the first frame update
    void Start()
    {
        _cubeBox = _cube.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_check == true && _numero == 1)
        {
            _cube.SetActive(true);
            _cubeRig.useGravity = false;
            _cubeRig.isKinematic = true;
            
        }
        else
        {
            _cube.SetActive(false);
        }

        
    }
}
