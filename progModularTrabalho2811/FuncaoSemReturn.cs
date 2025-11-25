using System;
using System.ComponentModel;

public static class FuncaoSemReturn
{
    public static void DiaHoje(ref DateTime data, ref TimeOnly hora)
    {
        data = DateTime.Today;
        hora = TimeOnly.FromDateTime(DateTime.Now);
    }
}