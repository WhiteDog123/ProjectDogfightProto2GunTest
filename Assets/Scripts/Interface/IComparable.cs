using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IComparable<T> {
    int CompareTo(T other);
}
