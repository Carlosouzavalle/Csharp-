using System;

public class Calculator
{
    public Calculator() { }

    public int Calculate(string op, int value1, int value2)
    {
        if (op == "+")
        {
            return value1 + value2;
        }
        else if (op == "-")
        {
            return value1 - value2;
        }
        else if (op == "*")
        {
            return value1 * value2;
        }
        else if (op == "/")
        {
            return value1 / value2;
        }
        else
        {
            return 0;
        }

    }
}
