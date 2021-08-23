using System;

namespace NullFrameworkException
{
	public class Optional<T>
	{
		public static Optional<T> Empty() => new Optional<T>(default);
		public static Optional<T> Of(T _value) => new Optional<T>(_value);

		private T value = default;
		private bool hasUpdated = false;

		protected Optional(T _value) => value = _value;

		public bool IsEmpty() => value == null || (hasUpdated && value == null);
		public T Get() => value;

		public void Update(T _value)
		{
			if(hasUpdated)
				throw new InvalidOperationException($"Cannot update already updated optional!");

			value = _value;
			hasUpdated = _value == null;
		}
	}
}