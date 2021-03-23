using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [SerializeField]
    ScoreKeeper marcador;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /* quando a bola bater, avisamos o ScoreKeeper
         * para aumentar a pontuação
         */

        marcador.Goal();




    }
}
