using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ComandosBotao : MonoBehaviour
{
    // Start is called before the first frame update
   public void iniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void InstrucoesJogo()
    {
        SceneManager.LoadScene("Instrucoes");
    }
}
