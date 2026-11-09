using UnityEngine;
using TMPro;
using System;
using System.Text;

public class RankingUI : MonoBehaviour
{
    public TMP_InputField campoNome;
    public TMP_Text textoRanking;

    private float tempoFinal;

    // Recebe o tempo total da partida
    public void DefinirTempoFinal(float tempo)
    {
        tempoFinal = tempo;
    }

    // Registra o jogador no ranking
    public void RegistrarResultado()
    {
        string nome = campoNome.text.Trim();

        if (string.IsNullOrEmpty(nome))
        {
            textoRanking.text = "Digite seu nome!";
            return;
        }

        RankingManager.RegistrarJogador(nome, tempoFinal);

        campoNome.interactable = false;

        AtualizarRanking();
    }

    // Exibe os 10 melhores jogadores
    public void AtualizarRanking()
    {
        var jogadores = RankingManager.CarregarRanking();

        StringBuilder texto = new StringBuilder();

        texto.AppendLine("RANKING ARCOR");
        texto.AppendLine();

        int limite = Mathf.Min(10, jogadores.Count);

        for (int i = 0; i < limite; i++)
        {
            TimeSpan tempo = TimeSpan.FromSeconds(
                jogadores[i].tempo
            );

            texto.AppendLine(
                (i + 1) + "º - " +
                jogadores[i].nome + " - " +
                tempo.ToString(@"mm\:ss")
            );
        }

        textoRanking.text = texto.ToString();
    }

    void Start()
    {
        AtualizarRanking();
    }
}
