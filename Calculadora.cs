public class Class1
{
    private int num1;
    private int num2;

    public Calculadora()
    {
    }

    public global::System.Int32 Num1 { get => num1; set => num1 = value; }
    public global::System.Int32 Num2 { get => num2; set => num2 = value; }

    public int Suma()
    {
        return num1 + num2;
    }

}
