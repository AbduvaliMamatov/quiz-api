namespace Quiz.Infrastructure.Exceptions;

public class CustomUnauthorizedExcetion(string errorMessage)
: Exception(errorMessage) { } 