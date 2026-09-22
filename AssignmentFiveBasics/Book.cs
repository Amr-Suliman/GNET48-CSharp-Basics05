namespace AssignmentFiveBasics
{
    class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;

        public string TItle;

        public Genre BookGenre { get; set; }
    }
}
