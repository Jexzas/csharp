class Student {
    private int[] scores = new int[5];
    public string name = "";
    public decimal finalScore;
    public decimal average;
    public string finalGrade = "";
    public void addScore(int score) {
        Array.Resize(ref scores, scores.Length + 1);
        scores[scores.Length - 1] = score;
    }
    public int getExtraCredit() {
        int credits = 0;
        foreach (int score in scores) {
            if (Array.IndexOf(scores, score) >= 5) {
                credits += score;
            }
        }
        return credits;
    }
    public decimal getScoreNoExtra() {
        int noEcScore = 0;
        foreach (int score in scores) {
            if(Array.IndexOf(scores, score) <= 4) {
                noEcScore += score;
            }
        }
        decimal thisAvg = noEcScore / 5;
        return thisAvg;
    }
    public void getFinalGrade() {
        foreach (int score in scores) {
            if (Array.IndexOf(scores, score) <= 4) {
                finalScore += score;
            } else {
                finalScore = finalScore + (score * 1.1m);
            }
        }

        average = finalScore / 5;

        if (average > 96) {
            finalGrade = "A+";
        } else if (average > 92) {
            finalGrade = "A";
        } else if (average > 89) {
            finalGrade = "A-";
        } else if (average > 86) {
            finalGrade = "B+";
        } else if (average > 82) {
            finalGrade = "B";
        } else if (average > 79) {
            finalGrade = "B-";
        } else if (average > 76) {
            finalGrade = "C+";
        } else if (average > 72) {
            finalGrade = "C";
        } else if (average > 69) {
            finalGrade = "C-";
        } else if (average > 66) {
            finalGrade = "D+";
        } else if (average > 62) {
            finalGrade = "D";
        } else if (average > 59) {
            finalGrade = "D-";
        } else {
            finalGrade = "F";
        }

    }

    public Student(int score1, int score2, int score3, int score4, int score5, string name){
        this.scores[0] = score1;
        this.scores[1] = score2;
        this.scores[2] = score3;
        this.scores[3] = score4;
        this.scores[4] = score5;
        this.name = name;
    }

    public string displayScoresAll() {
        string display = "";
        foreach (int score in scores) {
            display += score.ToString() + " ";
        }
        return display;
    }

};

class Program {
    public static void Main(String[] args) {
        Student sophia = new Student(66, 76, 77, 66, 99, "Sophia");
        Student andrew = new Student(66, 98, 95, 78, 80, "Andrew");
        andrew.addScore(15);
        Student emma = new Student(77, 77, 77, 77, 78, "Emma");
        Student logan = new Student(99, 1, 1, 99, 1, "Logan");
        Student[] students = {sophia, andrew, emma, logan};
        Console.WriteLine($"Student\t\tExam Score\tOverall Grade\tExtra Credit");
        foreach(Student student in students){
            student.getFinalGrade();
            decimal ecPoints = student.average - student.getScoreNoExtra();
            Console.WriteLine($"{student.name}:\t\t{student.getScoreNoExtra()}\t\t{student.average}\t{student.finalGrade}\t{student.getExtraCredit()} ({ecPoints})");
            
            Console.WriteLine(student.displayScoresAll());
        }
    }
}