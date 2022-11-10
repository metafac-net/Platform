# Platform 
Abstractions and implementations for common platform capabilities:
- System Clock
- Randon Number Source

## Abstractions
- ITimeOfDayClock
- IMonotonicClock
- IRandomNumberSource

## Runtime implementations
- TimeOfDayClock
- MonotonicClock
- PsuedoRandom

## Testing  fakes
- ManualStepClock
- MonotonicTimeOfDayClock
- PseudoRandomWithSeed
- SequentialNumberSource
