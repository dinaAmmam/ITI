"use strict";
var _a;
let car;
car = {
    name: "Toyota",
    model: 1990,
    printDetails: function () {
        return `${this.name} ${this.model}`;
    },
    printDetailsArrow: () => {
        return `${car.name} ${car.model}`;
    },
};
let car2 = {
    name: "Kia",
    model: 5000,
};
let car2PrintDetails = (_a = car.printDetails) === null || _a === void 0 ? void 0 : _a.bind(car2);
console.log(car2PrintDetails);
