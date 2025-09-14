using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalButtonHandler : MonoBehaviour, IClickable
{
    [SerializeField] private GameObject _portalPart;

    public void OnClick()
    {
        _portalPart.SetActive(true);
    }
}
