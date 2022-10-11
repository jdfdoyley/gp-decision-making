/*******************************************************************************
 * Name: Jason D. F. D'Oyley
 * Date: Oct. 11, 2022
 * Assignment CIS214 Week 2 GP - Decisions & Logical Operators
 *
 * Main application (program) class.
 * In this application we will demonstrate how logical operators function by
 * printing "truth" tables to show the results of various logical and
 * conditional operators. We will also explore decision making through
 * the use of both an if-else statement and a switch statement.
*/
public class application
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine(
            "Jason D'Oyley - Week 2 GP Decisions & Logical Operators\n"
        );

        // Display a truth table for conditional AND (&&) operator
        Console.WriteLine(
            "Conditional AND (&&):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
            "false && false", false && false,
            "false && true", false && true,
            "true && false", true && false,
            "true && true", true && true
        );

        // Display a truth table for conditional OR (||) operator
        Console.WriteLine(
            "Conditional OR (||):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
            "false || false", false || false,
            "false || true", false || true,
            "true || false", true || false,
            "true || true", true || true
        );

        // Display a truth table for logical AND (&) operator
        Console.WriteLine(
            "Logical AND (&):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
            "false & false", false & false,
            "false & true", false & true,
            "true & false", true & false,
            "true & true", true & true
        );

        // Display a truth table for logical OR (|) operator
        Console.WriteLine(
            "Logical OR (|):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
            "false | false", false | false,
            "false | true", false | true,
            "true | false", true | false,
            "true | true", true | true
        );

        // Display a truth table for logical exclusive OR (^) operator
        Console.WriteLine(
            "Logical exclusive OR (^):\n{0}: {1}\n{2}: {3}\n{4}: {5}\n{6}: {7}\n",
            "false ^ false", false ^ false,
            "false ^ true", false ^ true,
            "true ^ false", true ^ false,
            "true ^ true", true ^ true
        );

        // Display a truth table for logical negation (!) operator
        Console.WriteLine(
            "Logical negation (!):\n{0}: {1}\n{2}: {3}\n",
            "!false", !false,
            "!true", !true
        );
    }
}