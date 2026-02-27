let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

let unique = [...new Set(numbers)];
console.log(unique);



let uniqueNums = [...new Set(numbers)];
uniqueNums.sort((a,b) => b - a); // decending order
console.log("Second Largest =", uniqueNums[1]);

let freq = {};
for (let num of numbers) {
  freq[num] = (freq[num] || 0) + 1;
}
console.log(freq);




let firstUnique;
for (let num of numbers) {
  if (freq[num] === 1) {
    firstUnique = num;
    break;
  }
}

console.log("First Non-Repeating =", firstUnique);


let k = 2;
let rotated = numbers.slice(k).concat(numbers.slice(0, k));
console.log(rotated);


let arr = [1, 2, [3, 4, [5]]];
let flat = arr.flat(2);
console.log(flat);


let arr2 = [1,2,3,5,6];
let missing;
for (let i = 1; i <= 6; i++) {
  if (!arr2.includes(i)) {
    missing = i;
    break;
  }
}

console.log("Missing =", missing);