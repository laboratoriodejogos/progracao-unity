using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exemplo01 : MonoBehaviour
{
    /*
        Inteiro     |   int 
        Real        |   float
        Caracteres  |   string
        Lógico      |   bool
    */

    // Start is called before the first frame update
    void Start()
    {
        int valor2, tentativas = 10;
        float peso, n1, n2;
        string nome_Personagem, valor1;
        bool vida;

        //tentativas = 10;
        peso = 98.5f;
        nome_Personagem = "Joao";
        vida = true;
        valor1 = "9";

        peso = tentativas;
        tentativas = (int)peso;
        print("Tentativas = " + tentativas);
        print("Peso = " + peso);

        tentativas = int.Parse(valor1);
        tentativas = tentativas + 10;
        print("Soma de Tentativas = " + tentativas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
