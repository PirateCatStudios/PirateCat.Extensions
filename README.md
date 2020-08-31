### Pirate Cat Extensions

Various extension methods collected over the years.

## Float Extensions

- Round() (Similar to the `Vector3.Round()`)

## GameObject Extensions

- HasComponent<T>()

## List Extensions

- Shuffle(int seed)
- IsSubsetOf(IList<T> otherList)
- ToHashSet<T>()

## MonoBehavior Extensions

- Invoke(Action action, float delay)
- Invoke<T>(Action<T> action, T arg, float delay)

## NavMeshAgent Extensions

- NearestValidDestination(Vector3 destination)
- ResetMovement()

## StopWatch Extensions

- GetTicksDeltaAsMilliseconds(long previousTick)

## String Extensions

- AfterFirst(string substring)
- AfterLast(string substring)
- BeforeFirst(string substring)
- BeforeLast(string substring)
- GetStableHashCode()
- PrefixMatch(string prefix)

## Vector Extensions
Extension methods for Unity's Vector3 and Vector2 types

- Distance(Vector3 to)
- Distance2D(Vector3 to)
- GetNormalized2D()
- IsZero()
- Round()
- Round(float size)
- To2D()


