# Platform 

[![Build Status](https://dev.azure.com/MetaFac/OSR/_apis/build/status/Platform?branchName=main)](https://dev.azure.com/MetaFac/OSR/_build/latest?definitionId=5&branchName=main)

Abstractions and implementations for common platform capabilities:
- Time Of Day Clock
- Montonic Clock
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
