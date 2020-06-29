# Show Slider Text
With this class you can show the value of a Slider in a text component.

## Script settings in Inspector
<img src="../master/Example.png">

## Steps for use
1. Attach the **ShowSliderText.cs** script to the **Slider component** that will provide the value.

2. **Text:** Attach a text component to show the value.

3. **Hidden Slider:** If true, hide the slider.

4. **Round:** Used to round up the value that will be shown in the text.

5. **Before Text:** Used to concatenate text before the value.

6. **After Text:** Used to concatenate text after the value.

**Note**
TextUpdate() method  must be called in the OnValueChanged of the Slider component to update the text value when the Slider is moved.
