# ScalarAPI
## Declarative approach to some manipulations with scalars.
### This project is an attempt to make familiar imperative code lazy, more object - oriented and declarative
For example:
  * objects which encapsulate result of some boolean operations
  * find extremum value in some collection
  * cache any scalar if it's computation is slow or smth
  * retry computation if it fails
  * combine all described operations because all classes implements one iterface `IScalar<T>`
