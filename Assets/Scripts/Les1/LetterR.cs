using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterR : MonoBehaviour, IClickable
{
    private MeshRenderer _meshRenderer;
    private Material _material;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = _meshRenderer.material;
    }

    public void OnClick()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_material.DOColor(Color.red, 2.0f));
        sequence.AppendInterval(1.0f);
        sequence.Append(_material.DOColor(Color.white, 2.0f));

        sequence.Play();
    }
}
