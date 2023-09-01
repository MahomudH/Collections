namespace CollectionsTypes.StackApp
{
    public class Command
    {
        private readonly string _url;
        private readonly DateTime _createdAt;

        public Command(string url)
        {
            _url = url;
            _createdAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{this._createdAt.ToString("yyyy-MM-dd hh:mm")}] {this._url}";
        }
    }
}
