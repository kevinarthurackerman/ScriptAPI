namespace ScriptAPI.Procedures
{
    public interface IFunctionProcedure<TOutput> : IProcedure
    {
        TOutput Do();
    }

    public interface IFunctionProcedure<T, TOutput> : IProcedure
    {
        TOutput Do(T input);
    }

    public interface IFunctionProcedure<T1, T2, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2);
    }

    public interface IFunctionProcedure<T1, T2, T3, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13, T14 input14);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13, T14 input14, T15 input15);
    }

    public interface IFunctionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TOutput> : IProcedure
    {
        TOutput Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13, T14 input14, T15 input15, T16 input16);
    }
}
