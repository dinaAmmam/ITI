import {circle} from "./circle.js";
import {rectangle} from "./rectangle.js";
import {traingle} from "./traingle.js";
//import square from "./square.js";
import {square} from "./square.js";

let rect = new rectangle (200,100);
let cir = new circle(50);
let tr = new traingle(20,50);
let sqr = new square(20);


let sh = [rect , cir , tr, sqr ];
sh.forEach((sh) => {
    console.log(sh.calcArea());
})