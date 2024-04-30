using System.Diagnostics;
using System.Text.RegularExpressions;

Process[] allProcesses = Process.GetProcesses();
List<string> riotNames = new List<string>() { "Riot", "Valorant", "League" };

var processesToKill = allProcesses
            .Where(p => riotNames.Any(pattern => Regex.IsMatch(p.ProcessName, pattern)));

foreach (Process process in processesToKill)
{
    if(process.ProcessName != "RiotKiller") //mb my code is suicidal...
    {
        Console.WriteLine($"Killing process: {process.ProcessName}");
        process.Kill();
    }
}