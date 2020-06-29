/**
 * @author Kleber Ribeiro da Silva
 * @email krsmga@gmail.com
 * @create date 2020-06-29 13:42:58
 * @modify date 2020-06-29 13:42:58
 * @desc With this class you can show the value of a Slider in a text component.
 * @github https://github.com/krsmga/ShowSliderText
 */
using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// With this class you can show the value of a Slider in a text component.
/// </summary>
/// <remarks>
/// <param name="_text">Attach a text component to show the value.</param>
/// <param name="_hiddenSlider">If true, hide the slider.</param>
/// <param name="_round">Used to round up the value that will be shown in the text.</param>
/// <param name="_beforeText">Used to concatenate text before the value.</param>
/// <param name="_afterText">Used to concatenate text after the value.</param>
/// </remarks>
public class ShowSliderText : MonoBehaviour 
{
	[SerializeField] private Text[] _text = default;
	[SerializeField] private bool _hiddenSlider = default;
	[SerializeField] private int _round = 0;
	[SerializeField] private string _beforeText = default;
	[SerializeField] private string _afterText = default;
	
	private Slider _sliderComponent;

	void Start () 
	{
		_sliderComponent = GetComponent<Slider> ();
		if (_hiddenSlider)
		{
			Image[] __images = GetComponentsInChildren<Image>(true);
			foreach (Image __i in __images) 
			{
			 	__i.enabled = false;
			}
		}
	}

	/// <summary>
	/// It must be called in the OnValueChanged of the Slider component to update the text value when the Slider is moved.
	/// </summary>
	public void TextUpdate (float __value) 
	{
		foreach (Text __i in _text) 
		{
			__i.text = Math.Round(__value,_round).ToString();
			
			if (!string.IsNullOrEmpty(_beforeText))
			{
				__i.text = _beforeText + __i.text;
			}
			
			if (!string.IsNullOrEmpty(_afterText))
			{
				__i.text += _afterText;
			}
		}
	}
}