using System;

namespace dotnetapp.Exceptions
{

public class FrenchTuitionBookingException : Exception
{
    public FrenchTuitionBookingException(string message) : base(message)
    {
    }
}
}