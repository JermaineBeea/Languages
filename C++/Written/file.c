#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main() {
    // #region 
    bool run_code = true;
    if (run_code == true) {
    
    int num1, num2, sum;
    // Ask the user for input
    printf("Enter first number: ");
    scanf("%d", &num1);
    printf("Enter second number: ");
    scanf("%d", &num2);

    // Calculate the sum
    sum = num1 + num2;

    // Print the result
    printf("The sum of %d and %d is %d\n", num1, num2, sum);

    return 0;
    }
    // #endregion

    char set[] = {1,2,3,4,5};
    char arr[] = {0,0};
    int size = sizeof(set) / sizeof(set[0]); // Calculate the size of the array

    // Allocate memory for the destination array
    int *net_set = (int *)malloc(size * sizeof(int));
    if (net_set== NULL) {
        printf("Memory allocation failed\n");
        return 1;
    }

     for (int n = 0; n < size; n++)
     {
      for (int n2 = n + 1; n2 < size; n2 ++ ){
        arr[0] = set[n];
        arr[1] = set[n2];
      }
     }

    
}

