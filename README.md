# Platform 

[![Build-Deploy](https://github.com/metafac-net/Platform/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/metafac-net/Platform/actions/workflows/dotnet.yml)
![NuGet Downloads](https://img.shields.io/nuget/dt/MetaFac.Platform)

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

## Testing fakes
- ManualStepClock
- MonotonicTimeOfDayClock
- PseudoRandomWithSeed
- SequentialNumberSource
