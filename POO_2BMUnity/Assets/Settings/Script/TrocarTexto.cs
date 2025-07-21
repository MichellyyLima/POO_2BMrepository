using TMPro;
using UnityEngine;

public class trocartexto : MonoBehaviour
{
    public string texto;
    public TextMeshProUGUI textoUI;
        
    public void trocartextoUI()
    {
        textoUI.text = texto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
