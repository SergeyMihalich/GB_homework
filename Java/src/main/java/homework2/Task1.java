package homework2;
import org.json.JSONObject;

public class Task1 {
    public static void main(String[] args) {
        JSONObject filters = new JSONObject("{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}");
        StringBuilder whereClause = new StringBuilder("select * from students where ");

        String name = filters.optString("name", null);
        if (name != null) {
            whereClause.append("name = '").append(name).append("' AND ");
        }

        String country = filters.optString("country", null);
        if (country != null) {
            whereClause.append("country = '").append(country).append("' AND ");
        }

        String city = filters.optString("city", null);
        if (city != null) {
            whereClause.append("city = '").append(city).append("' AND ");
        }

        String age = filters.optString("age", null);
        if (age != null && !age.equals("null")) {
            whereClause.append("age = ").append(age).append(" AND ");
        }

        if (whereClause.toString().endsWith("AND ")) {
            whereClause.delete(whereClause.length() - 4, whereClause.length());
        }

        System.out.println(whereClause.toString());
    }
}
