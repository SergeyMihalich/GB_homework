package homework5;
import java.util.*;

public class Task1 {
    public static void main(String[] args) {
        HashMap<String, HashSet<String>> phoneBook = new HashMap<>();
        addContact(phoneBook, "Анна", "333333333");
        addContact(phoneBook, "Иван", "666666666");
        addContact(phoneBook, "Николай", "555555555");
        addContact(phoneBook, "Игорь", "111111111");
        addContact(phoneBook, "Елена", "999999999");

        List<Map.Entry<String, HashSet<String>>> sortedEntries = new ArrayList<>(phoneBook.entrySet());
        Collections.sort(sortedEntries, new Comparator<Map.Entry<String, HashSet<String>>>() {
            @Override
            public int compare(Map.Entry<String, HashSet<String>> entry1, Map.Entry<String, HashSet<String>> entry2) {
                return Integer.compare(entry2.getValue().size(), entry1.getValue().size());
            }
        });

        System.out.println("Телефонная книга:");
        for (Map.Entry<String, HashSet<String>> entry : sortedEntries) {
            System.out.println(entry.getKey() + ": " + entry.getValue());
        }
    }

    public static void addContact(Map<String, HashSet<String>> phoneBook, String name, String phoneNumber) {
        HashSet<String> phoneNumbers = phoneBook.getOrDefault(name, new HashSet<>());
        phoneNumbers.add(phoneNumber);
        phoneBook.put(name, phoneNumbers);
    }
}

