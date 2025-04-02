using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Button> _fields;

    private List<bool> _chooses;

    private void Awake()
    {

    }

    public void OnFieldClick(Button field)
    {
        _fields.Contains(field);
        Debug.Log("True");
    }
}
