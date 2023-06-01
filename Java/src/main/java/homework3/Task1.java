package homework3;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;

public class Task1 {
    public static void main(String[] args) {
        List<Integer> numbers = new ArrayList<>();
        Random random = new Random();

        for (int i = 0; i < 10; i++) {
            numbers.add(random.nextInt(100));
        }

        System.out.println("Исходный список: " + numbers);

        numbers.removeIf(n -> n % 2 == 0);

        System.out.println("Список после удаления четных чисел: " + numbers);

        int min = Collections.min(numbers);
        System.out.println("Минимальное значение: " + min);

        int max = Collections.max(numbers);
        System.out.println("Максимальное значение: " + max);

        double average = numbers.stream()
                .mapToDouble(Integer::doubleValue)
                .average()
                .orElse(0);
        System.out.println("Среднее значение: " + average);
    }
}
