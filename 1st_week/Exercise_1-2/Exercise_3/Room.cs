namespace Exercise_1_2
{
    public struct Room
    {
        private int number;

        public Room(int number)
        {
            this.number = number;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public override string ToString()
        {
            return $"{number}";
        }
    }
}