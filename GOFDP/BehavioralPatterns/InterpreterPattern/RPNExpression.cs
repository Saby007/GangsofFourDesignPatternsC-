using System;

/// <summary>
/// The abstract RPN Expression Class
/// </summary>
public abstract class RPNExpression
{
    /// <summary>
    /// Interpret the expressions
    /// </summary>
    /// <returns>value of the interpreter</returns>
    public abstract int Interpret();
}
