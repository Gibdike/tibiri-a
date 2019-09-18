using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMutacao : MonoBehaviour
{
    // Start is called before the first frame update
     private Text clicks;
    public GameObject clicker;
    public Click click;
    // Start is called before the first frame update
    void Start()
    {
        clicks = GetComponent<Text>();
        click = clicker.GetComponent<Click>();
    }

    // Update is called once per frame
    void Update()
    {
        clicks.text = click.mutacoes.ToString();
    }
}
