using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;

    [SerializeField] bool _checkCube;
            
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_checkCube == false)
        {
            _cube.SetActive(false);
        }
        else
        {
            _cube.SetActive(true);
        }

        if (_checkCube == false)
        {
            _cylinder.SetActive(false);
        }
        else
        {
            _cylinder.SetActive(true);
        }

        if (_checkCube == false)
        {
            _capsule.SetActive(false);
        }
        else
        {
            _capsule.SetActive(true);
        }

        if (_checkCube == false)
        {
            _sphere.SetActive(false);
        }
        else
        {
            _sphere.SetActive(true);
        }
    }
}
