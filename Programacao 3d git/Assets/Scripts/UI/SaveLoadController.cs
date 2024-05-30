using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadController : MonoBehaviour
{
    public GameObject player;

    public GameObject painelMenu;
    private bool habilitado = false;
    public KeyCode abrePainel;

    public InputField inpNome;
    public Text txtsave1;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(abrePainel))
            habilitado = !habilitado;
        if (habilitado)
        {
            painelMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            painelMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Salvar()
    {
        PlayerPrefs.SetString("Save1", inpNome.text);
        PlayerPrefs.SetFloat("Save1PosX", player.transform.position.x);
        PlayerPrefs.SetFloat("Save1PosY", player.transform.position.y);
        PlayerPrefs.SetFloat("Save1PosZ", player.transform.position.z);
        txtsave1.text = inpNome.text;
    }
    public void LoadSave1()
    {
        float x, y, z;
        x = PlayerPrefs.GetFloat("Save1PoxX");
        y = PlayerPrefs.GetFloat("Save1PoxY");
        z = PlayerPrefs.GetFloat("Save1PoxZ");
        player.transform.position = new Vector3(x, y, z);
    }
}
