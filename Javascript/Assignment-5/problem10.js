class MathUtils {
  static add(a, b) {
    return a + b;
  }

  static subtract(a, b) {
    return a - b;
  }

  static multiply(a, b) {
    return a * b;
  }
}

console.log("Add:", MathUtils.add(10, 20));
console.log("Subtract:", MathUtils.subtract(30, 10));
console.log("Multiply:", MathUtils.multiply(5, 6));