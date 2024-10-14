import java.util.Scanner;
import java.util.ArrayList;

public class comb {
    public static void main(String[] args) {
      
      int alphasize = 6;
      char [] alphabetArray = new char [alphasize];
      for (int n = 0; n < alphasize; n++){
        alphabetArray[n] = (char)('a' + n);
      }

      char [] set = alphabetArray;

      ArrayList<char []> NetSet = new ArrayList <>();
      int size = set.length;

      for (char n = 0; n < size; n++){
        for (int n2 = n + 1; n2 < size; n2++){
          char [] arr = new char [2];
          arr[0] = set[n];
          arr[1] = set[n2];
          NetSet.add(arr);

        }
      }

      for (char[] arr : NetSet) {
        System.out.println(arr[0] + ", " + arr[1]);
      }  

    }
}
