namespace ConsoleApp.Model
{
    internal class Notes : INotes
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Note { get; private set; }

        public void SetId(int id)
        {
            Id = id;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetNote(string note)
        {
            Note = note;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nTitle: {Title}\nNote: {Note}\n\n";
        }
    }
}
