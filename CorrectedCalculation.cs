public class ExampleClass{
    public int Calculate(int a, int b) {
        if (b == 0) {
            throw new ArgumentException("Denominator cannot be zero");
        }
        if (a == 0 || b == 0) {
            return 0;
        }
        return a / b; 
    }
} 