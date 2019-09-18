using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
     public string nome;
    public string descricao;

    public int custo;
    public int bonusClick;  

    public int maxUp;
    private int qntUp;

    public GameObject clicker;
    private Click click;

    public GameObject textoNome;
    private Text txtNome;

    public GameObject textoDescricao;
    private Text txtDescription;

    public GameObject textoCusto;
    private Text txtCusto;

    public GameObject maxedContent;
    public bool maxed;

    public GameObject cantBuy;

    public SpriteRenderer areaClicker;

    public GameObject barra;
    private Barra progresso;
    public GameObject mutacao;
    public GameObject up1;
    public GameObject up2;
    public GameObject up3;
    public GameObject up4;
    public GameObject up5;


    void Start()
    {
        click = clicker.GetComponent<Click>();

        txtNome = textoNome.GetComponent<Text>();
        txtDescription = textoDescricao.GetComponent<Text>();
        txtCusto = textoCusto.GetComponent<Text>();
        progresso = barra.GetComponent<Barra>();

       

        if(maxUp == 0){
            maxUp = 100;
        }
    }

    void Update() {
        txtNome.text = nome;
        txtDescription.text = descricao;
        txtCusto.text = custo.ToString();
        if(qntUp == maxUp){
            maxedContent.SetActive(true);
            maxed = true;
        }else{
            maxedContent.SetActive(false);
            maxed = false;
        }
        if(nome == "Mutacao"){
            if(click.numClick < custo){
                cantBuy.SetActive(true);
                maxed = true;
            }else{
                cantBuy.SetActive(false);
                maxed = false;
            }
        }else{
            if(click.mutacoes < custo){
                cantBuy.SetActive(true);
                maxed = true;
            }else{
                cantBuy.SetActive(false);
                maxed = false;
            }
        }
    }

    public void Comprar(){
        if(nome == "Mutacao"){
            click.mutacoes++;
            
            if(click.numClick >= custo && !maxed){
           
                click.numClick -= custo;
               
            }
        }else{
             if(click.mutacoes >= custo && !maxed){
                click.mutacoes = click.mutacoes - custo;
                click.qntClicks += bonusClick;
                qntUp++;
                if(nome == "Divisao"){
                mutacao.GetComponent<Upgrade>().custo -= 2;
                
                }
                if(nome == "Cromossomos"){
                mutacao.GetComponent<Upgrade>().custo -= 2;
                }
                if(nome == "Alga"){
                    click.numAlgas++;
                }
                if(nome == "Fixacao"){
                    maxUp = click.numAlgas;
                  
                }
                if(nome == "Multicelular"){
                    up1.GetComponent<Upgrade>().custo -= 10;
                    up2.GetComponent<Upgrade>().custo -= 10;
                    up3.GetComponent<Upgrade>().custo -= 10;
                    up5.GetComponent<Upgrade>().custo -= 10;
                }
                progresso.progressao();
            }
           
        }
    }
     public void TrocarBackground(Sprite imagem){
        areaClicker.sprite = imagem;
    }
}
