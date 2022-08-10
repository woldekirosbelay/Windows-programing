Console.WriteLine("WELOCOME TO THE CALCULATOR\nInput using these format\n\t\ta(+-*/)b");
String equation;
String left="", right="";
bool operatorFound = false;
int operatorIndex = 0;
char operators='+';
double result=0;

while (true)
{
    Console.WriteLine("Input");
    //getting input equation
    equation = Console.ReadLine();
    //getting left side
    for (int i = 0; i < equation.Length; i++)
    {
        if (equation[i] == '+' || equation[i] == '-' || equation[i] == '*' || equation[i] == '/')
        {
            operatorFound = true;
            operatorIndex = i;
            operators = equation[i];
        }

        if (operatorFound == false)
        {
            left += equation[i];
        }
    }

    //getting right side
    for (int i = 0; i < equation.Length; i++)
    {
        if (i > operatorIndex)
        {
            right += equation[i];
        }
    }

    //calculating result
    if (operators == '+')
    {
        result = int.Parse(left) + int.Parse(right);
    }

    if (operators == '-')
    {
        result = int.Parse(left) - int.Parse(right);
    }

    if (operators == '*')
    {
        result = int.Parse(left) * int.Parse(right);
    }

    if (operators == '/')
    {
        result = int.Parse(left) / int.Parse(right);
    }

    Console.WriteLine("Result is " + result + "\n\n");
}
