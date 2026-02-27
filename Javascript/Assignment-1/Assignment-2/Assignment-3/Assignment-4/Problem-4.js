let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

let totalSalary = employees.reduce((sum, emp) => sum + emp.salary, 0);
console.log("Total Salary =", totalSalary);


let highest = employees.reduce((max, emp) =>
  emp.salary > max.salary ? emp : max
);

let lowest = employees.reduce((min, emp) =>
  emp.salary < min.salary ? emp : min
);

console.log("Highest Paid =", highest);
console.log("Lowest Paid =", lowest);


let updatedEmployees = employees.map(emp => {
  if (emp.dept === "IT") {
    emp.salary = emp.salary * 1.15;
  }
  return emp;
});
console.log(updatedEmployees);


let groupByDept = employees.reduce((group, emp) => {
  if (!group[emp.dept]) {
    group[emp.dept] = [];
  }
  group[emp.dept].push(emp);
  return group;
}, {});

console.log(groupByDept);


let deptAvg = {};

for (let dept in groupByDept) {
  let total = groupByDept[dept].reduce((sum, emp) => sum + emp.salary, 0);
  deptAvg[dept] = total / groupByDept[dept].length;
}
console.log(deptAvg);

let sortedEmployees = [...employees].sort((a, b) => b.salary - a.salary);
console.log(sortedEmployees);