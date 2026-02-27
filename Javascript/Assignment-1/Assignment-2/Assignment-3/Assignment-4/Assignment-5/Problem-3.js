class Student {
    constructor(name, marks) {
        this.name = name;
        this.marks = marks;
    }

    addMarks(mark) {
        // if (Array.isArray(mark)) {
        //     this.marks.push(...mark);
        // } else {
        //     this.marks.push(mark);
        // }

         this.marks.push(mark); 
    }

    getAverage() {
        let sum = this.marks.reduce((a, b) => a + b, 0);
        return sum / this.marks.length;
    }

    getGrade() {
        let avg = this.getAverage();
        if (avg >= 90) return "A";
        else if (avg >= 75) return "B";
        else if (avg >= 60) return "C";
        else return "Fail";
    }
}

const s1 = new Student("Henry", [85, 90, 88]);

// s1.addMarks([10, 20, 40]);

s1.addMarks(10);
s1.addMarks(20);
s1.addMarks(40);

console.log("Marks:", s1.marks);
console.log("Average:", s1.getAverage());
console.log("Grade:", s1.getGrade());