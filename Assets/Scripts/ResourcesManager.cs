using TMPro;
using UnityEngine;

/// <summary>
/// Permet de gérer les ressources du jeu.
/// </summary>
public class ResourcesManager : MonoBehaviour
{
    /// <summary>
    /// Textbox affichant le nombre d'échantillons.
    /// </summary>
    public TextMeshProUGUI SamplesText;

    /// <summary>
    /// Textbox affichant le nombre de molécules
    /// </summary>
    public TextMeshProUGUI MoleculesText;

    /// <summary>
    /// Textbox affichant le nombre de cellules.
    /// </summary>
    public TextMeshProUGUI CellsText;

    /// <summary>
    /// Appelé au démarrage du script.
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// Appelé à chaque frame.
    /// </summary>
    void Update()
    {
        // calcule le temps écoulé depuis la dernière production
        _timer += Time.deltaTime;

        if (_timer >= productionInterval)
        {
            _timer = 0f;
            ProduceResources();
            UpdateUI();
        }
    }

    /// <summary>
    /// Gère la production automatique des ressources.
    /// </summary>
    void ProduceResources()
    {
        _samples += 1;
        _molecules += 1;
        _cells += 1;
    }

    /// <summary>
    /// Met à jour l'affichage des ressources.
    /// </summary>
    void UpdateUI()
    {
        SamplesText.text = $"Echantillons : {_samples}";
        MoleculesText.text = $"Mollécules : {_molecules}";
        CellsText.text = $"Cellules : {_cells}";
    }

    /// <summary>
    /// Nombre d'échantillons disponibles.
    /// </summary>
    private int _samples = 0;

    /// <summary>
    /// Nombre de molécules disponibles.
    /// </summary>
    private int _molecules = 0;

    /// <summary>
    /// Nombre de cellules disponibles.
    /// </summary>
    private int _cells = 0;

    /// <summary>
    /// référence de temps pour la production automatique des ressources.
    /// </summary>
    private float _timer = 0f;

    /// <summary>
    /// Intervalle de production automatique des ressources (en secondes).
    /// </summary>
    public float productionInterval = 1f;
}
