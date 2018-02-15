using System.Collections.Generic;
using System.Reflection;

namespace Comparer
{
    static class Comparer
    {
        public static List<Difference> GetDiffs<T>(this T value1, T value2)
        {
            List<Difference> diffs = new List<Difference>();
            PropertyInfo[] propertyInfo = value1.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public); //value1.GetType().GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var info in propertyInfo)
            {
                var diff = new Difference
                {
                    Property = info.Name,
                    ValueA = info.GetValue(value1),
                    ValueB = info.GetValue(value2)
                };
                
                if ((!Equals(diff.ValueA, diff.ValueB)))
                    diffs.Add(diff);
            }
            return diffs;
        }
    }

    class Difference
    {
        public string Property { get; set; }
        public object ValueA { get; set; }
        public object ValueB { get; set; }
    }
}
