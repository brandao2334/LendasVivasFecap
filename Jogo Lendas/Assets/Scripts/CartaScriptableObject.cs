using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Nova Carta", menuName = "Carta", order = 1)] //Possibilita a criação de um novo asset para carta

public class CartaScriptableObject : ScriptableObject
{
    public string NomeCarta;

    [TextArea]
    public string Descricao, Historia; //Area para textos maiores, informada no Inspetor

    public int VidaAtual, DanoAtaque, ManaCusto;

    public Sprite PersonagemSprite, FundoSprite;



}
