using System.Diagnostics;

namespace StartMinimized
{
    internal static class Program
    {
        [STAThread]
        static int Main()
        {
            var allArguments = Environment.GetCommandLineArgs();

            if (allArguments.Length < 2)
            {
                return 1;
            }

            var targetPath = allArguments[1];

            var targetArguments = allArguments.Skip(2);
            var targetArgumentText = string.Join(" ",
                targetArguments.Select(argument
                => $"\"{argument.Replace("\"", "\"\"")}\""));

            var startInfo = new ProcessStartInfo(targetPath, targetArgumentText)
            {
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Minimized
            };

            var process = Process.Start(startInfo);

            if (process == null)
            {
                return 2;
            }

            process.WaitForExit();

            return process.ExitCode;
        }
    }
}