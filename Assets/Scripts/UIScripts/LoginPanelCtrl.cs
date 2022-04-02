using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginPanelCtrl : MonoBehaviour
{
    GameObject panel_register;
    GameObject panel_start;
    Button btn_login;
    Button btn_back;
    Button btn_register_transfer;
    // Start is called before the first frame update
    void Start()
    {
        // retrieve the buttons:
        btn_login = transform.Find("btn_login").GetComponent<Button>();
        btn_back = transform.Find("btn_back").GetComponent<Button>();
        btn_register_transfer = transform.Find("btn_register_transfer").GetComponent<Button>();

        // add listener and events:
        btn_login.onClick.AddListener(LoginEvent);
        btn_back.onClick.AddListener(BackEvent);
        btn_register_transfer.onClick.AddListener(RegisterTransferEvent);
    }

    private void LoginEvent()
    {
        // What do you want to do when you click the login button?
    }

    private void RegisterTransferEvent()
    {
        // transfer to register page:
        panel_register = transform.parent.Find("panel_register").gameObject;
        panel_register.SetActive(true);
        gameObject.SetActive(false);
    }

    private void BackEvent()
    {
        // transfer back to start page:
        panel_start = transform.parent.Find("panel_start").gameObject;
        panel_start.SetActive(true);
        gameObject.SetActive(false);
    }

}