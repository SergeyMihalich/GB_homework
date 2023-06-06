package homework4;

import java.util.Collections;
import java.util.LinkedList;

public class Task1 {
    public static <T> LinkedList<T> reverseLinkedList(LinkedList<T> list) {
        Collections.reverse(list);
        return list;
    }

    public static class Queue<T> {
        private LinkedList<T> queue = new LinkedList<>();

        public void enqueue(T element) {
            queue.add(element);
        }

        public T dequeue() {
            return queue.remove();
        }

        public T first() {
            return queue.peek();
        }
    }

    public static void main(String[] args) {
        LinkedList<Integer> list = new LinkedList<>();
        for (int i = 1; i <= 10; i++) {
            list.add(i);
        }
        System.out.println("Исходный список: " + list);

        LinkedList<Integer> reversedList = reverseLinkedList(list);
        System.out.println("Перевернутый список: " + reversedList);

        Queue<Integer> queue = new Queue<>();
        for (int i = 1; i <= 10; i++) {
            queue.enqueue(i);
        }
        System.out.println("Первый элемент очереди: " + queue.first());
        System.out.println("Извлеченный элемент из очереди: " + queue.dequeue());
        System.out.println("Первый элемент очереди после извлечения: " + queue.first());
    }
}
