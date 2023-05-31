package homework2;
import java.io.FileWriter;
import java.io.IOException;

public class Task2 {
    public static void main(String[] args) {
        int[] arr = {5, 3, 8, 2, 1};
        int n = arr.length;
        boolean swapped;

        try (FileWriter logFile = new FileWriter("sort.log")) {
            for (int i = 0; i < n - 1; i++) {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++) {
                    if (arr[j] > arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }

                logFile.write("После итерации " + (i + 1) + ": ");
                for (int k = 0; k < n; k++) {
                    logFile.write(arr[k] + " ");
                }
                logFile.write("\n");

                if (!swapped) {
                    break;
                }
            }

            System.out.println("Массив после сортировки пузырьком:");
            for (int num : arr) {
                System.out.print(num + " ");
            }
            System.out.println();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

