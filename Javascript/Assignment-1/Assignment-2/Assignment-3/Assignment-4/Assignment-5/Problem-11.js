class User {
  constructor(password) 
  {
    this._password = password;
  }

  set password(newPassword) 
  {
    if (newPassword.length >= 6) {
      this._password = newPassword;
      console.log("Password updated successfully");
    } else {
      console.log("Password must be at least 6 characters");
    }
  }

  get password() {
    return this._password;
  }
}

const user1 = new User("abc4606");

console.log(user1.password);

user1.password = "4606";
user1.password = "secure99";

console.log(user1.password);