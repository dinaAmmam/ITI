import { shape } from "./shape.js";
export class rectangle extends shape{

    #hight =0;
    #width =0;
    constructor(_width , _hight){
        super();
        this.Width = _width;
        this.Hight = _hight;
    }
    set Width(_w){
        this.#width = _w
    }
    get Width(){
        return this.#width;
    }
    set Hight(_hight){
        this.#hight = _hight
    }
    get Hight(){
        return this.#hight;
    }
    calcArea(){
        return this.Hight + this.Width;
    }
}