let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

//pass
let passed = students.filter(n => n.marks >=40);
console.log(passed);


let distintion = students.filter(n => n.marks >= 85);
console.log(distintion);


//calculate avg
let total = students.reduce((sum, s) => sum+s.marks, 0);
console.log("Class total:",total);
let avg = total / students.length;
console.log("Class Average: ",avg);


//find topper
let topper = students.reduce((top, s) => s.marks > top.marks ? s : top);
let toppers = students.reduce((top, s) =>{
        if (s.marks > top.marks)
            return s;
        else
            return top;
},students[0]);
console.log(topper);
console.log(toppers);

//fail
let count = students.filter(n => n.marks < 45).length;
console.log(count);


//grades

students.forEach(s => {
  if (s.marks >= 85) s.grade = "A";
  else if (s.marks >= 70) s.grade = "B";
  else if (s.marks >= 50) s.grade = "C";
  else s.grade = "Fail";
});

console.log(students);