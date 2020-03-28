using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityCooldown : MonoBehaviour {

    public string abilityButtonAxisName = "Attack";
    public Image darkMask;
    public Text cooldownTextDisplay;

    [SerializeField] private Ability ability;   // Remove later
    [SerializeField] private GameObject weaponHolder;   // Remove later
    private Image myButtonImage;
    private AudioSource abilitySource;
    private float cooldownDuration;
    private float nextReadyTime;
    private float cooldownTimeLeft;


    void Start() {
        Initialize(ability, weaponHolder);   // Remove later
        myButtonImage = GetComponent<Image>();
        abilitySource = GetComponent<AudioSource>();
        myButtonImage.sprite = ability.aSprite;
        darkMask.sprite = ability.aSprite;
        cooldownDuration = ability.aBaseCoolDown;
        ability.Initialize(weaponHolder);
        AbilityReady();
    }

    public void Initialize(Ability selectedAbility, GameObject weaponHolder) {

    }

    void Update() {
        bool cooldownComplete = (Time.time > nextReadyTime);

        if (cooldownComplete) {
            AbilityReady();

            if (Input.GetButtonDown(abilityButtonAxisName)) {
                ButtonTriggered();
            }
        } else {
            Cooldown();
        }
    }

    private void AbilityReady() {
        cooldownTextDisplay.enabled = false;
        darkMask.enabled = false;
    }

    private void Cooldown() {
        cooldownTimeLeft -= Time.deltaTime;
        float roundedCd = Mathf.Round(cooldownTimeLeft);
        cooldownTextDisplay.text = cooldownTimeLeft.ToString("F1");
        darkMask.fillAmount = (cooldownTimeLeft / cooldownDuration);
    }

    private void ButtonTriggered() {
        nextReadyTime = cooldownDuration + Time.time;
        cooldownTimeLeft = cooldownDuration;
        darkMask.enabled = true;
        cooldownTextDisplay.enabled = true;
        
        abilitySource.clip = ability.aSound;
        abilitySource.Play();
        ability.TriggerAbility();
    }
}
