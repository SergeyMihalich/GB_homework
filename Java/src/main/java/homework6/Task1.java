package homework6;
import java.util.*;

public class Task1 {
    public static void main(String[] args) {
        Set<Notebook> notebooks = createNotebooks();

        filterNotebooks(notebooks);
    }

    public static Set<Notebook> createNotebooks() {
        Set<Notebook> notebooks = new HashSet<>();

        Notebook notebook1 = new Notebook("Red", "Brand1", true, 15.6, 2.1);
        Notebook notebook2 = new Notebook("Blue", "Brand2", false, 13.3, 1.8);
        Notebook notebook3 = new Notebook("Black", "Brand1", true, 14.0, 2.5);
        Notebook notebook4 = new Notebook("Silver", "Brand3", false, 15.6, 2.3);
        Notebook notebook5 = new Notebook("Red", "Brand2", true, 13.3, 1.7);

        notebooks.add(notebook1);
        notebooks.add(notebook2);
        notebooks.add(notebook3);
        notebooks.add(notebook4);
        notebooks.add(notebook5);

        return notebooks;
    }

    public static void filterNotebooks(Set<Notebook> notebooks) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Введите критерии фильтрации:");
        System.out.println("1 - Цвет");
        System.out.println("2 - Бренд");
        System.out.println("3 - Подсветка клавиатуры");
        System.out.println("4 - Диагональ");
        System.out.println("5 - Вес");

        int criteria = scanner.nextInt();
        scanner.nextLine(); // Очистка буфера

        switch (criteria) {
            case 1:
                System.out.print("Введите цвет: ");
                String color = scanner.nextLine();
                filterByColor(notebooks, color);
                break;
            case 2:
                System.out.print("Введите бренд: ");
                String brand = scanner.nextLine();
                filterByBrand(notebooks, brand);
                break;
            case 3:
                System.out.print("Введите наличие подсветки клавиатуры (true/false): ");
                boolean hasBacklitKeyboard = scanner.nextBoolean();
                filterByBacklitKeyboard(notebooks, hasBacklitKeyboard);
                break;
            case 4:
                System.out.print("Введите диагональ: ");
                double screenSize = scanner.nextDouble();
                filterByScreenSize(notebooks, screenSize);
                break;
            case 5:
                System.out.print("Введите вес: ");
                double weight = scanner.nextDouble();
                filterByWeight(notebooks, weight);
                break;
            default:
                System.out.println("Некорректный выбор критерия фильтрации.");
        }
    }

    public static void filterByColor(Set<Notebook> notebooks, String color) {
        System.out.println("Результаты фильтрации по цвету " + color + ":");
        for (Notebook notebook : notebooks) {
            if (notebook.getColor().equalsIgnoreCase(color)) {
                System.out.println(notebook);
            }
        }
    }

    public static void filterByBrand(Set<Notebook> notebooks, String brand) {
        System.out.println("Результаты фильтрации по бренду " + brand + ":");
        for (Notebook notebook : notebooks) {
            if (notebook.getBrand().equalsIgnoreCase(brand)) {
                System.out.println(notebook);
            }
        }
    }

    public static void filterByBacklitKeyboard(Set<Notebook> notebooks, boolean hasBacklitKeyboard) {
        System.out.println("Результаты фильтрации по наличию подсветки клавиатуры " + hasBacklitKeyboard + ":");
        for (Notebook notebook : notebooks) {
            if (notebook.hasBacklitKeyboard() == hasBacklitKeyboard) {
                System.out.println(notebook);
            }
        }
    }

    public static void filterByScreenSize(Set<Notebook> notebooks, double screenSize) {
        System.out.println("Результаты фильтрации по диагонали " + screenSize + ":");
        for (Notebook notebook : notebooks) {
            if (notebook.getScreenSize() == screenSize) {
                System.out.println(notebook);
            }
        }
    }

    public static void filterByWeight(Set<Notebook> notebooks, double weight) {
        System.out.println("Результаты фильтрации по весу " + weight + ":");
        for (Notebook notebook : notebooks) {
            if (notebook.getWeight() == weight) {
                System.out.println(notebook);
            }
        }
    }

    static class Notebook {
        private String color;
        private String brand;
        private boolean backlitKeyboard;
        private double screenSize;
        private double weight;

        public Notebook(String color, String brand, boolean backlitKeyboard, double screenSize, double weight) {
            this.color = color;
            this.brand = brand;
            this.backlitKeyboard = backlitKeyboard;
            this.screenSize = screenSize;
            this.weight = weight;
        }

        public String getColor() {
            return color;
        }

        public String getBrand() {
            return brand;
        }

        public boolean hasBacklitKeyboard() {
            return backlitKeyboard;
        }

        public double getScreenSize() {
            return screenSize;
        }

        public double getWeight() {
            return weight;
        }

        @Override
        public String toString() {
            return "Notebook{" +
                    "color='" + color + '\'' +
                    ", brand='" + brand + '\'' +
                    ", backlitKeyboard=" + backlitKeyboard +
                    ", screenSize=" + screenSize +
                    ", weight=" + weight +
                    '}';
        }
    }
}

