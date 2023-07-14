using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invasores : MonoBehaviour
{
    public Invader[ ] prefabs;
    public int linhas = 5; 
    public int colunas = 11; 

    private void Awake ()
    {
        for (int linha = 0; linha <this.linhas; linha++)
        {
            for (int col = 0; col <this.colunas; col++)
            {
              Invader invader = Instantiate(this.prefabs[col],this.transform );
            }
        
                
            }
        }
}


