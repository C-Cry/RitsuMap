using UnityEngine;
using UnityEngine.EventSystems; // Required when using Event systems.

public class SearchUIManager : MonoBehaviour
{
    public GameObject searchPanel; // Assign your search results panel here
    public GameObject backgroundPanel; // Assign your new background panel here

    void Start()
    {
        // Optionally initialize panels to be hidden
        HidePanel();
    }

    public void TogglePanel()
    {
        // This will check the current active state of the searchPanel and reverse it
        bool isActive = searchPanel.activeSelf;
        searchPanel.SetActive(!isActive);
        backgroundPanel.SetActive(!isActive); // The background panel follows the search panel's state
    }

    // This method is specifically for hiding both the background and search panels
    public void HidePanel()
    {
        searchPanel.SetActive(false);
        backgroundPanel.SetActive(false); // Ensure the background panel is also hidden
    }

    // Call this method when the background panel is clicked
    public void OnBackgroundClicked()
    {
        // When the background is clicked, we want to ensure that we hide the panels
        HidePanel();
    }
}
