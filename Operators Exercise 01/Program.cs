using System;

namespace Operators_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare 2 variables x and y of type int and initialize them with these values x = 10 & y = 20
            int x = 10;
            int y = 20;

            // TODO: Add 20 to x and 60 to y
            x += 20;
            y += 60;

            // TODO: Subtract 10 from x and 70 from y
            x -= 10;
            y -= 70;

            // TODO: Multiply x by 3 and y by 2
            x *= 3;
            y *= 2;

            // TODO: Divide x by 6 and y by 1
            x /= 6;
            y /= 1;

            // TODO: Modulus x by 3 and y by 3
            x %= 3;
            y %= 3;


            // TODO: Pre-increment x then print it to the console
            ++x;
            y++;
            


            // Thought Experiment: What will the value of x and y be after going through this pre/post increment operation?
            x = ++x;
            y = y++;

            Console.WriteLine(x);
            Console.WriteLine(y);

            // TODO: x = ?
            // TODO: y = ?

            // Thought Experiment: What will the value of x and y be after going thought the pre/post increment again, only slightly changed up a bit?
            x++;
            ++y;

            // TODO: x = ?
            // TODO: y = ?

        }
    }
}
