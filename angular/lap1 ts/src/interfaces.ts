interface ICar {
    name: string;
    model: number;
    engine?: string;
    printDetails?: () => string;
    printDetailsArrow?: () => string;
  }
  
  let car: ICar;
  
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
  
  let car2: ICar = {
    name: "Kia",
    model: 5000,
  };
  
  let car2PrintDetails = car.printDetails?.bind(car2);
console.log(car2PrintDetails) ;