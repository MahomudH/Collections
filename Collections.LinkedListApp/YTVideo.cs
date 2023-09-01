namespace Collections.LinkedListApp
{
    public class YTVideo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return $"├── {Title} ({Duration})\n│\thttps://www.youtube.com/watch?v={Id}";
            // ─ (alt + 196)
            // ├ (alt + 195)
            // │ (alt + 179)
        }
    }
}
