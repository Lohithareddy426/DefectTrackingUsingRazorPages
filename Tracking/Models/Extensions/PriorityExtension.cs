using Tracking.Models;

namespace Tracking.Models.Extensions
{
    public static class PriorityExtension
    {
        public static Dictionary<Priority, string> _priorityCSSClass = new Dictionary<Priority, string>()
        {
            [Priority.High] = "badge bg-danger",
            [Priority.Medium] = "badge bg-warning text-dark",
            [Priority.Low] = "badge bg-success"
        };

        public static string ToCSSClass(this Priority priority)
        {
            return _priorityCSSClass[priority];
        }

    }
}
