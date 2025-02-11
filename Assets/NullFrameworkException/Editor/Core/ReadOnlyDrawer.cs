using System.Collections;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;


namespace NullFrameworkException.Editor
{
	[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
	public class ReadOnlyDrawer : PropertyDrawer
	{
		
		public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
		{
			EditorGUI.BeginProperty(_position, _label, _property);
			{
				//Disable the GUI, maing this readonly, as it still renders, jsut becomes non-interactable
				GUI.enabled = false;
				{
					//Render the property exactly as it already is
					EditorGUI.PropertyField(_position, _property, _label);
				}
				//Re-enble the GUI to make everything work after this property
				GUI.enabled = true;
			}
			EditorGUI.EndProperty();
		}
		
		
	}
}