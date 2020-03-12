using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aula2 : MonoBehaviour
{
    int vida_player1, vida_player2, dano_player1, dano_player2;
    bool resultado;
    // Start is called before the first frame update
    void Start()
    {
        vida_player1 = 100;
        vida_player2 = 100;

        dano_player1 = 10;
        dano_player2 = 200;


        print("Aula 2");
        print(vida_player1 == vida_player2);
        vida_player2 = vida_player2 - dano_player1;

        print(vida_player1 == vida_player2);
        print(vida_player1 > vida_player2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
