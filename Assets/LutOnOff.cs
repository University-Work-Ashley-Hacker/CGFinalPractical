using UnityEngine;
using UnityEngine.UI;

public class LutOnOff : MonoBehaviour
{
	RawImage _rawImage;
	
	[SerializeField] Material _lut;

	bool on = true;
	
	void Awake()
	{
		_rawImage = GetComponent<RawImage>();
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			ChangeOnState();
		}
	}
	void ChangeOnState()
	{
		on = !on;

		if (on)
		{
			_rawImage.material = _lut;
		} else
		{
			_rawImage.material = null;	
		}
	}
}
