let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];


for(let i of books)
{
    console.log(i.title);   
}

let total = books.reduce((sum, book) => sum + (book.price * book.stock),0);
console.log(total);

let costlyBooks = books.filter(b => b.price > 500);
console.log(costlyBooks);

let updatedBooks = books.map(b => ({...b, price: b.price * 1.05
}));
console.log(updatedBooks);

//sort
let sortedBooks = [...books].sort((a, b) => a.price - b.price);
console.log(sortedBooks);

//removeId
let removeId = 2;
let remainingBooks = books.filter(b => b.id !== removeId);
console.log(remainingBooks);

//some()
let outOfStock = books.some(b => b.stock === 0);
console.log(outOfStock);