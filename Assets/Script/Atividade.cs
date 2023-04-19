using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade : MonoBehaviour
{
    [SerializeField]string _nome = "Jotapê";
    [SerializeField]int _idade;
    [SerializeField]float _pesa;

    [SerializeField]string _resultado;


    // Start is called before the first frame update
    void Start()
    {
       _resultado = _nome + " " + "tem" + " " + _idade + " " + "e pesa" + " " + _pesa + " " + "Kilos";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
