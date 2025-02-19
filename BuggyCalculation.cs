public class ExampleClass{
    public int Calculate(int a, int b) {
        if (a == 0 || b == 0) {
            return 0; // Incorrect handling of zero values
        }
        return a / b; // Potential for DivideByZeroException if b is 0 
    }
}