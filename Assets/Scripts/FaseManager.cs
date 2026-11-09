using UnityEngine;

public class FaseManager : MonoBehaviour
{
    [SerializeField] private TimerManagement timer;

    public void ConcluirFase()
    {
        // Impede que o cronômetro continue
        timer.StopTimer();

        // Obtém o tempo decorrido
        float tempoFase = timer.GetElapsedTime();

        // Registra o tempo da fase
        RankingManager.RegistrarTempoFase(tempoFase);

        Debug.Log("Tempo da fase: " + tempoFase);

        // Aqui você pode carregar a próxima fase
    }
}
