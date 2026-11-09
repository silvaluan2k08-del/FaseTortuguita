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



        if (textoRanking == null)
        {
            Debug.LogError("TextoRanking não foi atribuído!");
            return;
        }

        var jogadores = RankingManager.CarregarRanking();

        if (jogadores == null)
        {
            Debug.LogError("Ranking não foi carregado!");
            return;
        }

        StringBuilder texto = new StringBuilder();

        texto.AppendLine("RANKING PROJETO ARCOR");
        texto.AppendLine();

        int limite = Mathf.Min(10, jogadores.Count);

        for (int i = 0; i < limite; i++)
        {
            float tempo = jogadores[i].tempo;

            int minutos = Mathf.FloorToInt(tempo / 60);
            int segundos = Mathf.FloorToInt(tempo % 60);

            string tempoFormatado = minutos.ToString("00") + ":" +
                                    segundos.ToString("00");

            texto.AppendLine(
                (i + 1) + " - " +
                jogadores[i].nome.PadRight(25) +
                tempoFormatado
            );
        }
        textoRanking.text = texto.ToString();
    }

    void Start()
    {
        AtualizarRanking();
    }
}
