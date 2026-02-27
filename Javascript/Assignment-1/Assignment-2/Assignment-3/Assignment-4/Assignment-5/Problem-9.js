class Product {
  constructor({ name, price, category = "General" }) {
    this.name = name;
    this.price = price;
    this.category = category;
  }

  // Arrow function + Template literals
  display = () => {
    console.log(`Product: ${this.name}, Price: ₹${this.price}, Category: ${this.category}`);
  };

  // Default parameter + Arrow function
  applyDiscount = (discount = 10) => {
    this.price -= (this.price * discount) / 100;
    console.log(`Price after ${discount}% discount: ₹${this.price}`);
  };

  // Spread operator
  clone = () => {
    return new Product({ ...this });
  };
}

// Object creation using destructuring
const product1 = new Product({
  name: "Washing Machine",
  price: 25000,
  category: "Electronics"
});

product1.display();
product1.applyDiscount();

const product2 = product1.clone();
product2.display();