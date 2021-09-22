using System;

namespace Amazon_Robot_Bounded_In_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsRobotBounded("GGLLGG"));
        }

        static Boolean IsRobotBounded(string instructions)
        {
            int[] pos = new int[] { 0, 0 };

            int[,] dirs = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
            int face = 0;
            foreach (var c in instructions)
            {
                if (c == 'L')
                    face = face == 0 ? 3 : face - 1;
                else if (c == 'R')
                    face = face == 3 ? 0 : face + 1;
                else
                {
                    pos[0] = pos[0] + dirs[face, 0];
                    pos[1] = pos[1] + dirs[face, 1];
                }
            }
            return (face != 00 || (pos[0] == 0 && pos[1] == 0));
        }
    }
}
