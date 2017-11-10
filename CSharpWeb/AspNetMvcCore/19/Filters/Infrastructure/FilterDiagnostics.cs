using System.Collections.Generic;

//c Add FilterDiagnostics.cs which cotains IFilterDiagnostics and its implementation, DefaultFilterDiagnostics class.

namespace Filters.Infrastructure
{
    public interface IFilterDiagnostics
    {
        IEnumerable<string> Messages { get; }
        void AddMessage(string message);
    }

    public class DefaultFilterDiagnostics : IFilterDiagnostics
    {
        private List<string> messages = new List<string>();
        public IEnumerable<string> Messages => messages;
        public void AddMessage(string message) =>
            messages.Add(message);
    }
}