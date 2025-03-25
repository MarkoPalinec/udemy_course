using System;

namespace Application.Core;

public class Results<T>
{

    public bool IsSucess { get; set; }
    public T? Value { get; set; }
    public string Error { get; set; }
    public int Code { get; set; }

    public static Results<T> Success(T value) => new() { IsSucess = true, Value = value };

    public static Results<T> Faliure(string error, int code) => new()
    {
        IsSucess = false,
        Error = error,
        Code = code
    };

}
