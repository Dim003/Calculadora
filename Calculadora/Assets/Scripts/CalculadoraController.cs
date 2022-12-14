using System.Collections;
using System.Data;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculadoraController : MonoBehaviour
{

    [SerializeField] private Text TextDisplayI; 
    [SerializeField] private Text TextDisplayII;
    
    private string _expression;

    void Start()
    {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }

    void Update()
    {

    }

    public void BtnChacaracter(string character) 
    {
        TextDisplayII.text = character;
        TextDisplayI.text = TextDisplayI.text + TextDisplayII.text;
    }

    public void ExpressionCalculator()
    {
        _expression = TextDisplayI.text;
        DataTable table = new DataTable("tabela");
        string _result = table.Compute(_expression, string.Empty).ToString();
        TextDisplayII.text = _result;
    }

    public void CleanAll() 
    {
        TextDisplayI.text = "";
        TextDisplayII.text = "";
    }
    
}
