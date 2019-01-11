namespace ScriptAPI.Procedures
{
    public interface IActionProcedure : IProcedure
    {
        void Do();
    }

    public interface IActionProcedure<T> : IProcedure
    {
        void Do(T input);
    }

    public interface IActionProcedure<T1, T2> : IProcedure
    {
        void Do(T1 input1, T2 input2);
    }

    public interface IActionProcedure<T1, T2, T3> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3);
    }

    public interface IActionProcedure<T1, T2, T3, T4> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4);
    }
    
    public interface IActionProcedure<T1, T2, T3, T4, T5> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13, T14 input14);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13, T14 input14, T15 input15);
    }

    public interface IActionProcedure<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IProcedure
    {
        void Do(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5, T6 input6, T7 input7, T8 input8, T9 input9, T10 input10, T11 input11, T12 input12, T13 input13, T14 input14, T15 input15, T16 input16);
    }
}
