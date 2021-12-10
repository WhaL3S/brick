class Brick
    {
        private int length,
                    width,
                    height;
        public Brick(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int GetBrickLength() { return length; }
        public int GetBrickWidth() { return width; }
        public int GetBrickHeight() { return height; }

        static int OneWall(Brick b, double wallLength, double wallWidth, double wallHeight)
        {
            return (int)(wallLength * 1000 / b.GetBrickLength() *
                         wallWidth * 1000 / b.GetBrickWidth() *
                         wallHeight * 1000 / b.GetBrickHeight());
        }

        static void PrintBrick(Brick b)
        {
            Console.WriteLine("Brick length: {0,3:d} \nBrick width: {1,4:d} \n" +
                "Brick height:{2,4:d}\n", b.GetBrickLength(),
                                          b.GetBrickWidth(),
                                          b.GetBrickHeight());
        }

        static void Main(string[] args)
        {
            Brick b1 = new Brick(250, 120, 88);
            PrintBrick(b1);

            Brick b2 = new Brick(240, 115, 71);
            PrintBrick(b2);

            Brick b3 = new Brick(240, 115, 61);
            PrintBrick(b3);

            double wallLength = 12.0,
                   wallWidth = 0.23,
                   wallHeight = 3.0;

            int q1;
            q1 = OneWall(b1, wallLength, wallWidth, wallHeight);
            Console.WriteLine("Number (quantity) of   I-type bricks required: {0,6:d} ", (4 * q1));

            int q2;
            q2 = OneWall(b2, wallLength, wallWidth, wallHeight);
            Console.WriteLine("Number (quantity) of  II-type bricks required: {0,6:d} ", (4 * q2));

            int q3;
            q3 = OneWall(b3, wallLength, wallWidth, wallHeight);
            Console.WriteLine("Number (quantity) of III-type bricks required: {0,6:d} \n", (4 * q3));
        }

    }
