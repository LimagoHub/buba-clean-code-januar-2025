﻿namespace ArrayFillerUebung.buba.container;

public abstract class AbstractArrayFactory<T> :IArrayFactory<T>
{
    protected T[] Data { get; private set; }

    protected abstract void FillData() ;
    public  T[] CreateAndFillArray(int size)
    {
        Data = new T[size];
        FillData();
        return Data;
    }
}