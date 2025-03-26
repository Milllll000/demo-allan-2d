using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PausaController : MonoBehaviour
{
    public static UIDocument pausa;
    private Button boton_continuar;
    private Button boton_salir;
    
    void OnEnable()
    {
        pausa = GetComponent<UIDocument>();
        var root = pausa.rootVisualElement;
        boton_continuar = root.Q<Button>("BotonContinuar");
        boton_salir = root.Q<Button>("BotonSalir");

        boton_continuar.RegisterCallback<ClickEvent, bool>(CerrarPausa, false);
        boton_salir.RegisterCallback<ClickEvent, string>(RegresarMenuPrincipal, "EscenaMenu");
    }

    private void CerrarPausa(ClickEvent evt, bool estatus)
    {
        pausa.enabled = estatus;
    }

    private void RegresarMenuPrincipal(ClickEvent evt, string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
