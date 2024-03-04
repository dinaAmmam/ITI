import { shape } from "./shape.js";
export class circle extends shape{
    #radius = 0;
    constructor(radius){
        super();
        this.Radius = radius;
    }
    set Radius(_radius){
        if(_radius > 0)
        this.#radius=_radius;
    }
    calcArea(radius){
        return this.Radius*2;
    }

}