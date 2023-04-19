using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Textos : MonoBehaviour
{
    [SerializeField] string _nome;
    [SerializeField] string _sobrenome;
    [SerializeField] string _nomeCompleto;
    [SerializeField] Text _text;
    [SerializeField] int time;

    // Start is called before the first frame update
    void Start()
    {
        _nomeCompleto = _nome + " " + _sobrenome;
        _text.text = _nomeCompleto;
    }

    // Update is called once per frame
    void Update()
    {
        _text.fontSize += 1;
        
    }
}
