using UnityEngine;

public class SearchUIManager : MonoBehaviour
{
    public GameObject panel; // You will assign the Panel to this variable in the Inspector

    // Call this method to show the search results panel
    public void ShowPanel()
    {
        if (panel != null)
            panel.SetActive(true);
    }

    // Optional: Call this method to hide the panel
    public void HidePanel()
    {
        if (panel != null)
            panel.SetActive(false);
    }
}
