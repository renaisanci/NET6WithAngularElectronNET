namespace SmartSim.UI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public Guid  Number { get; set; }
        public string? Instrument { get; set; }
        public string? ASTM { get; set; }
        public string? HL7 { get; set; }
        public string? Cobas { get; set; }
        public string Poct1 { get; set; }
        public string? WinMonitor { get; set; }

    }
}