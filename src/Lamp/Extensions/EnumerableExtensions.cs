namespace Lamp;

internal static class EnumerableExtensions
{
    extension<TSource>(IEnumerable<TSource> source) // extension members for IEnumerable<TSource>
    {
        public IReadOnlyList<TSource> ToSafeReadOnlyList()
        {
            return source switch
            {
                null => new List<TSource>(),
                IReadOnlyList<TSource> list => list,
                _ => source.ToList(),
            };
        }
    }
}