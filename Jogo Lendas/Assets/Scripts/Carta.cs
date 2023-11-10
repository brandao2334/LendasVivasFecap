using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //para habilitar os textos
using UnityEngine.UI; // para habilitar as imagens

public class Carta : MonoBehaviour
{
    public CartaScriptableObject CartaSO;
    //Adicionando as variaveis para a carta (Poderiam ser todos os ints em uma linha, porém assim fica estéticamente melhor)
    public int VidaAtual;
    public int DanoAtaque;
    public int ManaCusto;
    public TMP_Text VidaTexto, AtaqueTexto, ManaTexto, NomeTexto, DescricaoTexto, HistoriaTexto; //abre uma variavel para textos
    public Image ArtePersonagem, ArteFundo;
    // Start is called before the first frame update
    void Start()
    {
        SetupCarta(); //Chama os dados da carta de dentro do CartaSO


    }

    public void SetupCarta()
    {
        VidaAtual = CartaSO.VidaAtual; //Vida atual recebe os valores contidos no CartaSO (Scriptable Object da carta)
        DanoAtaque = CartaSO.DanoAtaque;
        ManaCusto = CartaSO.ManaCusto;

        VidaTexto.text = VidaAtual.ToString(); //transforma a vida atual (int) em string
        AtaqueTexto.text = DanoAtaque.ToString();
        ManaTexto.text = ManaCusto.ToString();

        NomeTexto.text = CartaSO.NomeCarta;
        DescricaoTexto.text = CartaSO.Descricao;
        HistoriaTexto.text = CartaSO.Historia;

        ArtePersonagem.sprite = CartaSO.PersonagemSprite;
        ArteFundo.sprite = CartaSO.FundoSprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
