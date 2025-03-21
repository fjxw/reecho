﻿namespace Domain;

public interface IHandler<T>
{
    IHandler<T> SetNext(IHandler<T> handler); 
    Task HandleAsync(T request); 
}
