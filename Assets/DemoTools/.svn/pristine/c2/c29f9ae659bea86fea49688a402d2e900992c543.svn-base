using System;

[Serializable]
public class FloatArrayIterator<T> {

	[Serializable]
	public struct Entry  {
		public float Key;
		public T Value;

		public Entry(float key, T value) {
			Key = key;
			Value = value;
		}
	}

	private uint _index = 0;
	public uint CurrentIndex { get { return _index; } }

	private float _position = 0f;
	public float CurrentPosition { get { return _position; } }

	private Entry[] _array = new Entry[0];

	public Entry this[int i] {
		get { return _array[i]; }
	}

	public int Count {
		get { return _array.Length; }
	}

	public void Set(Entry[] array) {
		_array = array;
	
		if (_array != null) {
			Array.Sort(_array, (x, y) => {
				return x.Key.CompareTo (y.Key);
			});
		}
	
		Reset();
	}

	public bool Next(float position, out T value, out float delta) {

        value = default;

		delta = 0f;
	
		if (_array != null && _position <= position) {
			_position = position;
	
			while (_index < _array.Length) {
				var kv = _array[_index];
	
				if (kv.Key <= position) {
					value = kv.Value;
					delta = position - kv.Key;

					++_index;
	
					return true;
				} else
					break;
			}
		}
	
		return false;
	}

	public bool Next(float position, out T value) {
		float delta;
		return Next(position, out value, out delta);
	}

	public void SetStartPosition(float position) {
		_position = position;

		if (_array != null) {
            while (_index < _array.Length && _array[_index].Key <= position) {
                ++_index;
            }	
		}
	}

	public void Reset(uint index = 0, float position = 0f) {
		_index = index;
		_position = position;
	}
}
