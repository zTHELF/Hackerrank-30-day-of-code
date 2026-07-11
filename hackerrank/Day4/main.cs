class Person {
    public int age;

    public Person(int initialAge) {
        if (initialAge < 0) {
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        } else {
            age = initialAge;
        }
    }
    public void amIOld() {
        if (age < 13) {
            Console.WriteLine("You are young.");
        } else if (age < 18) {
            Console.WriteLine("You are a teenager.");
        } else {
            Console.WriteLine("You are old.");
        }
    }

    public void yearPasses() {
        age++;
    }
}

class Solution {
    static void Main(String[] args) {
        int T = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            int age = Int32.Parse(Console.ReadLine());
            Person p = new Person(age);
            for (int j = 0; j < 4; j++) {
                p.yearPasses();
            }
            p.amIOld();
        }
    }
}