using System.Collections;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;

namespace NullFrameworkException.Editor
{
	[CustomPropertyDrawer(typeof(TagAttribute))]
	public class TagDrawer : PropertyDrawer
	{
		public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
		{
			//Start drawing this specific instance of the tag property
			EditorGUI.BeginProperty(_position, _label, _property);
			//indicates the block of code is part of the property
			{
				//Determine if the proeperty was set to nothing by default
				bool isNotSet = string.IsNullOrEmpty(_property.stringValue);

				_property.stringValue = EditorGUI.TagField(_position, _label, isNotSet
					? (_property.serializedObject.targetObject as Component)?.gameObject.tag
					: _property.stringValue);
			}
			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty _property, GUIContent _label) => EditorGUIUtility.singleLineHeight;
	}
}