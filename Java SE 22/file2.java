import java.util.Scanner;
import java.util.ArrayList;

public class file2 {
    public static void main(String[] args) {
      
      int num1, num2, sum;

      // Create a Scanner object for user input
      Scanner scanner = new Scanner(System.in);

      // Ask the user for input
      System.out.print("Enter first number: ");
      num1 = scanner.nextInt();
      
      System.out.print("Enter second number: ");
      num2 = scanner.nextInt();

      // Calculate the sum
      sum = num1 + num2;

      // Print the result
      System.out.println("The sum of " + num1 + " and " + num2 + " is " + sum);

      // Close the scanner
      scanner.close();

      }
}
