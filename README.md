# Conveyor Monitor

Here's what's in the project so far.

## What's in it
- `ConveyorMonitor.sln`: opens all the projects together in your editor
- `src/ConveyorMonitor.Web`: the web app (right now it just says it's alive)
- `tests/ConveyorMonitor.Tests`: the test project (empty for now)
- `Domain/Models.cs`: the data shapes: `ConveyorStatus` (Running, Jam, Overheat), `Conveyor`, `SensorReading`, and `Alert`

## Run it
````
cd ConveyorMonitor-commit-1-2
dotnet run --project src/ConveyorMonitor.Web
````
Open http://localhost:5125. If you see "Conveyor Monitor is alive," it works.

