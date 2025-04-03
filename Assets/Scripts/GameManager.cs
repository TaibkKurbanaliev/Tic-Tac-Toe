using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Button> _fields;
    [SerializeField] private Sprite _cross;
    [SerializeField] private Sprite _circle;

    private List<bool> _chooses;

    private void Awake()
    {

    }

    public void OnFieldClick(Button field)
    {
        _fields.Contains(field);
        var img = field.GetComponent<Image>();
        img.sprite = _cross;
        img.color = Color.white;
        field.interactable = false;
        Debug.Log("True");
    }
}
