//string
let firstName: string = "Dina";

//number
let age: number = 20;

//boolean
let isTrue: boolean = true;

//array
let stringArr: string[] = ["Dina", "Mohamed"];
let numberArr: number[] = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//Union
let numOrString: string | number = "Dina";

let arrOfNumberOrArrString: string[] | number[] = ["Dina", "Mohamed"];
arrOfNumberOrArrString = [1, 2, 3];

let arrOfNumberOrString: (string | number)[] = [1, "Dina"];

//Type alias
type numOrString = string | number;
let stOrNumber: numOrString = 10;

type User = {
  id: number;
  username: string;
  email: string;
};

let user: User = {
  id: 1,
  username: "DinaMohamed",
  email: "dina.ammam34@gmail.com",
};

//Tuples
let article: [User, string, boolean] = [user, "Dina", true];

console.log(user);