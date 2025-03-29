using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


public class ConectarServidor : MonoBehaviour
{
    public struct Hora
    {
        public string hora;
    }

    void OnEnable()
    {
        EnviarDatosJSON();
    }

    private void EnviarDatosJSON()
    {
        StartCoroutine(SubirDatosJSON());
    }

    private IEnumerator SubirDatosJSON()
    {
        Hora prueba;
        prueba.hora = "Hola";

        string horaJSON = JsonUtility.ToJson(prueba);

        UnityWebRequest request = UnityWebRequest.Post("http://44.223.79.63:8080/", horaJSON, "application/JSON");

        yield return request.SendWebRequest();

        // Después de un rato
        if (request.result == UnityWebRequest.Result.Success)
        {
            print("\nConexión exitosa.\n\n");
        }
        else
        {
            print("Error de conexión: " + request.responseCode);
        }
    }
}
