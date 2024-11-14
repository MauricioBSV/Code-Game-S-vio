// Importa bibliotecas necessárias para coleções e funcionalidade Unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define uma classe chamada DetectionController que herda de MonoBehaviour
public class DetectionController : MonoBehaviour
{
    // Declara uma variável pública para armazenar a tag de detecção dos alvos
    public string _tagTargetDetection = "Player";

    // Cria uma lista para armazenar os objetos detectados
    public List<Collider2D> detectedObjs = new List<Collider2D>();

    // Método chamado automaticamente pelo Unity quando outro objeto entra no trigger do objeto atual
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se a tag do objeto que colidiu corresponde à tag do alvo de detecção
        if (collision.gameObject.tag == _tagTargetDetection)
        {
            // Adiciona o objeto detectado à lista detectedObjs
            detectedObjs.Add(collision);
        }
    }

    // Método chamado automaticamente pelo Unity quando outro objeto sai do trigger do objeto atual
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Verifica se a tag do objeto que colidiu corresponde à tag do alvo de detecção
        if (collision.gameObject.tag == _tagTargetDetection)
        {
            // Remove o objeto detectado da lista detectedObjs
            detectedObjs.Remove(collision);
        }
    }
}
