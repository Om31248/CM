namespace ConveyorMonitor.Web.Domain;

/// <summary>What a conveyor is doing right now. Running = healthy; the others are faults.</summary>
public enum ConveyorStatus
{
    Running = 0,
    Jam = 1,
    Overheat = 2
}

/// <summary>One belt on the plant floor.</summary>
public class Conveyor
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Zone { get; set; } = "";
}

/// <summary>One sensor reading from one conveyor. The simulator makes one per conveyor per second.</summary>
public class SensorReading
{
    public long Id { get; set; }
    public int ConveyorId { get; set; }
    public Conveyor? Conveyor { get; set; }

    /// <summary>Always UTC.</summary>
    public DateTime Timestamp { get; set; }

    public double SpeedMetersPerSec { get; set; }
    public double MotorTempC { get; set; }

    /// <summary>Result of the alert rules for this reading.</summary>
    public ConveyorStatus Status { get; set; }
}

/// <summary>Raised once when a conveyor goes from healthy to faulted (not on every bad reading).</summary>
public class Alert
{
    public long Id { get; set; }
    public int ConveyorId { get; set; }
    public Conveyor? Conveyor { get; set; }
    public DateTime Timestamp { get; set; }

    /// <summary>Jam or Overheat.</summary>
    public ConveyorStatus Kind { get; set; }

    public string Message { get; set; } = "";
}
