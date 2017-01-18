using UnityEngine;
using System.Collections;

public class InteractiveObject : MonoBehaviour 
{
	public enum eInteractiveState
	{
		Active, //OPen
		Inactive, //CLose
		
	}
	
	private eInteractiveState m_state;
	
	void Start()
	{
		m_state = eInteractiveState.Inactive;
	}
	
 	public void TrigegrInteraction()
	{
		if(!animation.isPlaying)
			{
			Debug.Log("Interactive object");
			switch (m_state) 
			{
			case eInteractiveState.Active:
				animation.Play("Close");
				m_state = eInteractiveState.Inactive;
				break;
			case eInteractiveState.Inactive:
				animation.Play("Open");
				m_state = eInteractiveState.Active;
				break;
			default:
			 	break;
			}
		}
	}
}
