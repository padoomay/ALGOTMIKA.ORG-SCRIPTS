using UnityEngine;

public class Destruction : MonoBehaviour
{
    private void Start()
    {
        // Разрушение объекта на котором есть данный скрипт
        Destroy(gameObject);
    }
}
