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
        int valor2, vida, tentativas = 10, pontos;
        float peso, n1, n2;
        string nome_Personagem, valor1;
        bool vivo;

        //tentativas = 10;
        peso = 98.5f;
        nome_Personagem = "Joao";
        vivo = true;
        valor1 = "9";
        pontos = 0;
        vida = 5;

        peso = tentativas;
        tentativas = (int)peso;
        print("Tentativas = " + tentativas);
        print("Peso = " + peso);

        tentativas = int.Parse(valor1);
        tentativas = tentativas + 10;
        print("Soma de Tentativas = " + tentativas);

        //  Ação de pontos
        //  pontos = pontos + 1;
        // Incremento
        pontos++;

        print("Pontos = " + pontos);

        //  Vidas
        //  A cada dano no personagem ele perde uma vida
        //  Decremento
        vida--;

        print("Vida atual = " + vida);
        print("Vida incremento = " + (vida++ + ++vida));
        print("Vida atual = " + vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
