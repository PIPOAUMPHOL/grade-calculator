// See https://aka.ms/new-console-template for more information

namespace GradeCalculator {
    class Program {
        static void Main () {
            int score;
            string grade;
            Console.Write("Input score: ");
            int.TryParse(Console.ReadLine(), out score);


            if(score >= 80 && score <= 100) {
                grade = "A";
            } else if (score >= 70 && score <= 79) {
                grade = "B";
            } else if (score >= 60 && score <= 69) {
                grade = "C";
            } else if (score >= 50 && score <= 59) {
                grade = "D";
            } else if (score < 50) {
                grade = "F";
            } else {
                grade = "Data not found";
            }

            Console.WriteLine(grade);
        }
    }
};
