namespace Exercise_1_2
{
    public struct Room
    {
        private int number;
        private bool isInstance;

        public Room(int number)
        {
            this.number = number;
            isInstance = true;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public override string ToString()
        {
            if (isInstance)
            {
                return $"{number}.";
            }
            else
            {
                return "Have no room, yet!";
            }

        }
    }
}