using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public int numClick;
    public int qntClicks;
    public int mutacoes;

    public int numAlgas;
    // Start is called before the first frame update
    private void Start() {
        numAlgas = 1;
    }
    
    public void Clicou(){
        numClick += qntClicks * numAlgas;
    }
}
