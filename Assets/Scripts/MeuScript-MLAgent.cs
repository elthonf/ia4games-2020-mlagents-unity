using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;

public class MyAgent : Agent
{
    Rigidbody rBody;
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Variáveis auxiliares expostas (Parametros)
    public Transform Target;
    public float speed = 10;

    /// <summary>
    /// Função que será chamada toda vez que precisar resetar a cena de treinamento
    /// </summary>
    public override void OnEpisodeBegin()
    {
       // Colocar aqui código para início
    }

    /// <summary>
    /// Função que obtém os parâmetros de entrada da rede neural
    /// </summary>
    /// <param name="sensor"></param>
    public override void CollectObservations(VectorSensor sensor)
    {
        // Colocar aqui código para os "sensores"
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        // Colocar aqui o código para "fazer algo"
    }

    public override void Heuristic(float[] actionsOut)
    {
        //Colocar aqui possíveis códigos que alterem a variável "actionsOut"
    }
}