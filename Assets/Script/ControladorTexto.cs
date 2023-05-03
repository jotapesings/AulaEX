using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTexto : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;
    [SerializeField] string _texto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_texto == "Cubo")
        {
            _cube.SetActive(false);
        }        
        else
        {
            _cube.SetActive(true);
        }
    }
}
