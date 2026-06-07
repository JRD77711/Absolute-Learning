using UnityEngine;

public class MaterialOpener : MonoBehaviour
{
    [Header("Material Link")]
    public string materialURL;

    public void OpenMaterial()
    {
        if (!string.IsNullOrEmpty(materialURL))
        {
            Application.OpenURL(materialURL);
        }
        else
        {
            Debug.LogWarning("Material URL belum diisi.");
        }
    }
}